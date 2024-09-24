using System.Data;

namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record CreateUserResponse
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public CreateUserResponse() { }
    public CreateUserResponse(string userName, string password, string phoneNumber)
    {
        Username = userName;
        Password = password;
        PhoneNumber = phoneNumber;
    }
}