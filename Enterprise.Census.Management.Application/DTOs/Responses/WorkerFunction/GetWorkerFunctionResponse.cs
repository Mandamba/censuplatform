namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerFunction;
public record GetWorkerFunctionResponse(
    long FunctionId,
    long PersonId,
    long DurationYear);
