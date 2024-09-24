using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Request.Core;
public record GetCoreRequest : IRequest<GetCoreResponse>;