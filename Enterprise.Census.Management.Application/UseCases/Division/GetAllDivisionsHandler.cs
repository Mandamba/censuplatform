using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Division;
using Enterprise.Census.Management.Application.DTOs.Responses.Division;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Division;
public class GetAllDivisionsHandler : IRequestHandler<GetAllDivisionsRequest, List<GetAllDivisionsResponse>>
{
    private readonly IDivisionRepository _divisionRepository;
    private readonly IMapper _mapper;

    public GetAllDivisionsHandler(IDivisionRepository divisionRepository, IMapper mapper)
    {
        _divisionRepository = divisionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllDivisionsResponse>> Handle(GetAllDivisionsRequest request, CancellationToken cancellationToken)
    {
        var divisions = await _divisionRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllDivisionsResponse>>(divisions);
    }
}
