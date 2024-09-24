using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record SendLoginRequest(string Username,string Password):IRequest<LoginResponse>;