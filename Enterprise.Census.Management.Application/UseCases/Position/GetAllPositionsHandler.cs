using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Position;
using Enterprise.Census.Management.Application.DTOs.Responses.Position;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Position;
public class GetAllPositionsHandler : IRequestHandler<GetAllPositionsRequest, List<GetAllPositionsResponse>>
{
    private readonly IPositionRepository _positionRepository;
    private readonly IMapper _mapper;

    public GetAllPositionsHandler(IPositionRepository positionRepository, IMapper mapper)
    {
        _positionRepository = positionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllPositionsResponse>> Handle(GetAllPositionsRequest request, CancellationToken cancellationToken)
    {
        var positions = await _positionRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllPositionsResponse>>(positions);
    }
}
