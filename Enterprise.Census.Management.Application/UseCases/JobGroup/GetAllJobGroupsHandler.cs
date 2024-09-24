using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.JobGroup;
using Enterprise.Census.Management.Application.DTOs.Responses.JobGroup;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.JobGroup;
public class GetAllJobGroupsHandler : IRequestHandler<GetAllJobGroupsRequest, List<GetAllJobGroupsResponse>>
{
    private readonly IJobGroupRepository _jobGroupRepository;
    private readonly IMapper _mapper;

    public GetAllJobGroupsHandler(IJobGroupRepository jobGroupRepository, IMapper mapper)
    {
        _jobGroupRepository = jobGroupRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllJobGroupsResponse>> Handle(GetAllJobGroupsRequest request, CancellationToken cancellationToken)
    {
        var jobGroups = await _jobGroupRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllJobGroupsResponse>>(jobGroups);
    }
}

