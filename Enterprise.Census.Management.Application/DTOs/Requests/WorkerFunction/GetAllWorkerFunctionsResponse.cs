using Enterprise.Census.Management.Application.DTOs.Responses.WorkerFunction;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerFunction;
public record GetAllWorkerFunctionsRequest : IRequest<List<GetAllWorkerFunctionsResponse>>;

