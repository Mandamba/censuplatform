using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerZone;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerZone;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllWorkZonesHandler : IRequestHandler<GetAllWorkZonesRequest, List<GetAllWorkZonesResponse>>
{
    private readonly IWorkZoneRepository _workZoneRepository;
    private readonly IMapper _mapper;

    public GetAllWorkZonesHandler(IWorkZoneRepository workZoneRepository, IMapper mapper)
    {
        _workZoneRepository = workZoneRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllWorkZonesResponse>> Handle(GetAllWorkZonesRequest request, CancellationToken cancellationToken)
    {
        var workZones = await _workZoneRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllWorkZonesResponse>>(workZones);
    }
}