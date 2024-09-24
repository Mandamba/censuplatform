using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Domain.Interfaces;
public interface IAuthRepository : IBaseRepository<User>
{
    Task<string> GenerateJwtTokenAsync(string username, string password);
    Task<User> ValidateUserAsync(string username, string password);
    Task<bool> CreateUserAsync(string username, string password);
    Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword);
    Task<bool> RequestPasswordResetAsync(string username);
    Task<bool> ResetPasswordAsync(string token, string newPassword);
}