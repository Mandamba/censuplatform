using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Direction;
using Enterprise.Census.Management.Application.DTOs.Responses.Direction;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Directions;
public class GetAllDirectionsHandler : IRequestHandler<GetAllDirectionsRequest, List<GetAllDirectionsResponse>>
{
    private readonly IDirectionRepository _directionRepository;
    private readonly IMapper _mapper;

    public GetAllDirectionsHandler(IDirectionRepository directionRepository, IMapper mapper)
    {
        _directionRepository = directionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllDirectionsResponse>> Handle(GetAllDirectionsRequest request, CancellationToken cancellationToken)
    {
        var directions = await _directionRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllDirectionsResponse>>(directions);
    }
}