using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerStateRequest;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.WorkerState;
public class GetAllWorkerStatesHandler : IRequestHandler<GetAllWorkerStatesRequest, List<GetAllWorkerStatesResponse>>
{
    private readonly IWorkerStateRepository _workerStateRepository;
    private readonly IMapper _mapper;

    public GetAllWorkerStatesHandler(IWorkerStateRepository workerStateRepository, IMapper mapper)
    {
        _workerStateRepository = workerStateRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllWorkerStatesResponse>> Handle(GetAllWorkerStatesRequest request, CancellationToken cancellationToken)
    {
        var workerStates = await _workerStateRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllWorkerStatesResponse>>(workerStates);
    }
}
