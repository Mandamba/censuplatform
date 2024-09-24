namespace Enterprise.Census.Management.Application.DTOs.Responses;
public class LoginResponse
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }
    public bool IsTemporaryPassword { get; set; }
    public string Message { get; set; }
}