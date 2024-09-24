using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record ChangePasswordRequest(string username, string oldPassword, string newPassword) : IRequest<bool>;