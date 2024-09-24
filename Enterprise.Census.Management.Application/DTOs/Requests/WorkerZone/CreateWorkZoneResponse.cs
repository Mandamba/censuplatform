using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record CreateWorkZoneRequest(
    long Id,
    string JobZone,
    string StudentWorker,
    long WorkerStateId,
    int WorkerConditionId,
    string DirectManager
    ) : IRequest<CreateWorkZoneResponse>;
