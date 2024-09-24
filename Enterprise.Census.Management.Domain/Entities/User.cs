namespace Enterprise.Census.Management.Domain.Entities;
public class User : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string? PasswordResetToken { get; set; }
    public bool IsTemporaryPassword { get; set; }
    public DateTime? ResetTokenExpiration { get; set; }
    public string? Role { get; set; }
}
