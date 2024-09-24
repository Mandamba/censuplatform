using Enterprise.Census.Management.Application.DTOs.Responses.Direction;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Direction;
public record CreateDirectionRequest(string Name) : IRequest<CreateDirectionResponse>;

