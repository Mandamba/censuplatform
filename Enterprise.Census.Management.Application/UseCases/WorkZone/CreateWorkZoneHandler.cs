using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateWorkZoneHandler : IRequestHandler<CreateWorkZoneRequest, CreateWorkZoneResponse>
{
    private readonly IWorkZoneRepository _workZoneRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateWorkZoneHandler(IWorkZoneRepository workZoneRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _workZoneRepository = workZoneRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateWorkZoneResponse> Handle(CreateWorkZoneRequest request, CancellationToken cancellationToken)
    {
        var workZone = _mapper.Map<WorkZone>(request);
        _workZoneRepository.Create(workZone);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateWorkZoneResponse>(workZone);
    }
}
