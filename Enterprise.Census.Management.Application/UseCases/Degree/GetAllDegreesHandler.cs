using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Degree;
using Enterprise.Census.Management.Application.DTOs.Responses.Degree;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Degree;
public class GetAllDegreesHandler : IRequestHandler<GetAllDegreesRequest, List<GetAllDegreesResponse>>
{
    private readonly IDegreeRepository _degreeRepository;
    private readonly IMapper _mapper;

    public GetAllDegreesHandler(IDegreeRepository degreeRepository, IMapper mapper)
    {
        _degreeRepository = degreeRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllDegreesResponse>> Handle(GetAllDegreesRequest request, CancellationToken cancellationToken)
    {
        var degrees = await _degreeRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllDegreesResponse>>(degrees);
    }
}
