using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using Enterprise.Census.Management.Domain.Utilis;
using Enterprise.Census.Management.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Enterprise.Census.Management.Persistence.Repositories;
public class AuthRepository : BaseRepository<User>, IAuthRepository
{


    private readonly ApplicationDbContext _context;
    private readonly JwtSettings _jwtSettings;
    private readonly string _twilioAccountSid;
    private readonly string _twilioAuthToken;
    private readonly string _twilioMessagingServiceSid;

    public AuthRepository(ApplicationDbContext context) : base(context)
    {
    }
    public AuthRepository(ApplicationDbContext context, IOptions<JwtSettings> jwtSettings, IOptions<TwilioSettings> twilioSettings) : base(context)
    {
        _context = context;
        _jwtSettings = jwtSettings.Value;
        _twilioAccountSid = twilioSettings.Value.AccountSid;
        _twilioAuthToken = twilioSettings.Value.AuthToken;
        _twilioMessagingServiceSid = twilioSettings.Value.MessagingServiceSid;
    }

    public async Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword)
    {
        var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);

        if (user == null)
        {
            return false;
        }

        if (!BCrypt.Net.BCrypt.Verify(oldPassword, user.Password))
        {
            return false;
        }

        var hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
        user.Password = hashedNewPassword;
        user.IsTemporaryPassword = false;

        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return true;
    }



    public async Task<bool> CreateUserAsync(string username, string phoneNumber)
    {
        if (await _context.Users.AnyAsync(u => u.Username == username))
        {
            return false;
        }

        var temporaryPassword = GenerateTemporaryPassword();
        var hashedPassword = HashPassword(temporaryPassword);

        var user = new User
        {
            Username = username,
            Password = hashedPassword,
            IsTemporaryPassword = true,
            PhoneNumber = phoneNumber,
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        SendPasswordBySms(phoneNumber, temporaryPassword);

        return true;
    }


    private string GenerateTemporaryPassword()
    {
        const int length = 8;
        const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder res = new StringBuilder(length);
        Random rnd = new Random();
        int remainingLength = length;

        while (remainingLength-- > 0)
        {
            res.Append(validChars[rnd.Next(validChars.Length)]);
        }

        return res.ToString();
    }



    public async Task<string> GenerateJwtTokenAsync(string username, string password)
    {
        var user = await ValidateUserAsync(username, password);

        if (user == null)
        {
            return null;
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_jwtSettings.Key);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                    new Claim(ClaimTypes.Name, user.Username)
                }),
            Expires = DateTime.UtcNow.AddHours(1),
            Issuer = _jwtSettings.Issuer,
            Audience = _jwtSettings.Audience,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public async Task<bool> RequestPasswordResetAsync(string username)
    {
        var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
        if (user == null)
        {
            return false;
        }

        var resetToken = Guid.NewGuid().ToString();
        user.PasswordResetToken = resetToken;
        user.ResetTokenExpiration = DateTime.UtcNow.AddHours(1);


        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return SendResetTokenBySms(user.PhoneNumber, resetToken);
    }


    public async Task<bool> ResetPasswordAsync(string token, string newPassword)
    {
        var user = await _context.Users.SingleOrDefaultAsync(u => u.PasswordResetToken == token);

        if (user == null || user.ResetTokenExpiration < DateTime.UtcNow)
        {
            return false;
        }

        user.Password = HashPassword(newPassword);
        user.PasswordResetToken = null;
        user.ResetTokenExpiration = null;
        user.IsTemporaryPassword = false;

        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return true;
    }


    public async Task<User> ValidateUserAsync(string username, string password)
    {
        var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return null;
        }
        return user;
    }

    private string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    private bool SendResetTokenBySms(string phoneNumber, string token)
    {
        try
        {
            TwilioClient.Init(_twilioAccountSid, _twilioAuthToken);

            var message = MessageResource.Create(
                body: $"Seu token de redefinição de senha é: {token}",
                from: new PhoneNumber(_twilioMessagingServiceSid),
                to: new PhoneNumber(phoneNumber)
            );

            return message.Status == MessageResource.StatusEnum.Queued ||
                   message.Status == MessageResource.StatusEnum.Sent;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return false;
        }
    }

    private string FormatPhoneNumber(string phoneNumber)
    {
        var cleanedPhoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

        if (cleanedPhoneNumber.StartsWith("+"))
        {
            return cleanedPhoneNumber;
        }
        return $"+244{cleanedPhoneNumber}";
    }

    private bool SendPasswordBySms(string phoneNumber, string temporaryPassword)
    {
        try
        {
            TwilioClient.Init(_twilioAccountSid, _twilioAuthToken);
            var formattedPhoneNumber = FormatPhoneNumber(phoneNumber);
            var message = MessageResource.Create(
                body: $"Sua senha temporária para acessar ao sistema do censo da força de trabalho da Epal é: {temporaryPassword}",
                from: new PhoneNumber(_twilioMessagingServiceSid),
                to: new PhoneNumber(formattedPhoneNumber)
            );

            return message.Status == MessageResource.StatusEnum.Queued ||
                   message.Status == MessageResource.StatusEnum.Sent;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return false;
        }
    }
}