using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Core;
public record CreateCoreRequest(string Name) : IRequest<CreateCoreResponse>;

