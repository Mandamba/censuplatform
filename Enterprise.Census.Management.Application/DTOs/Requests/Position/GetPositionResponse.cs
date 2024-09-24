using Enterprise.Census.Management.Application.DTOs.Responses.Position;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Position;
public record GetPositionRequest : IRequest<GetPositionResponse>;