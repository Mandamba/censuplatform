using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerCondition;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCondition;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.WorkerCondition;
public class GetAllWorkerConditionsHandler : IRequestHandler<GetAllWorkerConditionsRequest, List<GetAllWorkerConditionsResponse>>
{
    private readonly IWorkerConditionRepository _workerConditionRepository;
    private readonly IMapper _mapper;

    public GetAllWorkerConditionsHandler(IWorkerConditionRepository workerConditionRepository, IMapper mapper)
    {
        _workerConditionRepository = workerConditionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllWorkerConditionsResponse>> Handle(GetAllWorkerConditionsRequest request, CancellationToken cancellationToken)
    {
        var workerConditions = await _workerConditionRepository.GetAllWorkerConditionsAsync();
        return _mapper.Map<List<GetAllWorkerConditionsResponse>>(workerConditions);
    }
}
