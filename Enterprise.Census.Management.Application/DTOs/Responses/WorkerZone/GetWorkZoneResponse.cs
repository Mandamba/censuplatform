namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerZone;
public record GetWorkZoneResponse(
    long Id,
    string JobZone,
    string StudentWorker,
    long WorkerStateId,
    int WorkerConditionId,
    string DirectManager);
