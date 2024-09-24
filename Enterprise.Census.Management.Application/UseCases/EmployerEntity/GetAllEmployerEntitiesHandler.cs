using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.EmployerEntity;
using Enterprise.Census.Management.Application.DTOs.Responses.EmployerEntity;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

public class GetAllEmployerEntitiesHandler : IRequestHandler<GetAllEmployerEntitiesRquest, List<GetAllEmployerEntitiesResponse>>
{
    private readonly IEmployerEntityRepository _employerEntityRepository;
    private readonly IMapper _mapper;

    public GetAllEmployerEntitiesHandler(IEmployerEntityRepository employerEntityRepository, IMapper mapper)
    {
        _employerEntityRepository = employerEntityRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllEmployerEntitiesResponse>> Handle(GetAllEmployerEntitiesRquest request, CancellationToken cancellationToken)
    {
        var employerEntities = await _employerEntityRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllEmployerEntitiesResponse>>(employerEntities);
    }
}
