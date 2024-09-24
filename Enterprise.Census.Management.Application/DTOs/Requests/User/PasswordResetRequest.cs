using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.User;
public record PasswordResetRequest(string username) : IRequest<bool>;
