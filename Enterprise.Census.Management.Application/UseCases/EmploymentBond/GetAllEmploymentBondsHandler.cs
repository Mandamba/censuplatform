using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Request.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.EmploymentBond;
public class GetAllEmploymentBondsHandler : IRequestHandler<GetAllEmploymentBondsRequest, List<GetAllEmploymentBondsResponse>>
{
    private readonly IEmploymentBondRepository _employmentBondRepository;
    private readonly IMapper _mapper;

    public GetAllEmploymentBondsHandler(IEmploymentBondRepository employmentBondRepository, IMapper mapper)
    {
        _employmentBondRepository = employmentBondRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllEmploymentBondsResponse>> Handle(GetAllEmploymentBondsRequest request, CancellationToken cancellationToken)
    {
        var employmentBonds = await _employmentBondRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllEmploymentBondsResponse>>(employmentBonds);
    }
}

