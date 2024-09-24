using Enterprise.Census.Management.Application.DTOs.Responses.WorkerFunction;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerFunction;
public record CreateWorkerFunctionRequest(
    long FunctionId,
    long CategoryId,
    long PersonId,
    long DurationYear
    ) : IRequest<List<CreateWorkerFunctionResponse>>;
