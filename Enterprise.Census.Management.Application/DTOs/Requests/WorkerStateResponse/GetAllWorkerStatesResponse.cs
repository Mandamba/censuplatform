using Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerStateRequest;
public record GetAllWorkerStatesRequest : IRequest<List<GetAllWorkerStatesResponse>>;
