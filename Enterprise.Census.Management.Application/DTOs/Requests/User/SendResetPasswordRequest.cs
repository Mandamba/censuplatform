using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record SendResetPasswordRequest(string token, string newPassword) : IRequest<bool>;