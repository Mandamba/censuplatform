using Enterprise.Census.Management.Application.DTOs.Responses.WorkerZone;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerZone;
public record GetAllWorkZonesRequest : IRequest<List<GetAllWorkZonesResponse>>;

