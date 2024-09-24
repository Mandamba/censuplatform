using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCondition;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerCondition;
public record CreateWorkerConditionRequest(
    string Name
    ) : IRequest<CreateWorkerConditionResponse>;

