using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkBand;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkBand;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.WorkBand;
public class GetAllWorkBandsHandler : IRequestHandler<GetAllWorkBandsRequest, List<GetAllWorkBandsResponse>>
{
    private readonly IWorkBandRepository _workBandRepository;
    private readonly IMapper _mapper;

    public GetAllWorkBandsHandler(IWorkBandRepository workBandRepository, IMapper mapper)
    {
        _workBandRepository = workBandRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllWorkBandsResponse>> Handle(GetAllWorkBandsRequest request, CancellationToken cancellationToken)
    {
        var workBands = await _workBandRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllWorkBandsResponse>>(workBands);
    }
}