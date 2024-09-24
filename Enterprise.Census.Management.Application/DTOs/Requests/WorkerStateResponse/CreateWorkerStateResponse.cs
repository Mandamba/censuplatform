using Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerStateRequest;
public record CreateWorkerStateRequest(
    string Name
    ) : IRequest<CreateWorkerStateResponse>;
