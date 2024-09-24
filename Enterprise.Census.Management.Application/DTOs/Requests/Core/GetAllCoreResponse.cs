using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Core;
public record GetAllCoresRequest: IRequest<List<GetAllCoresResponse>>;

