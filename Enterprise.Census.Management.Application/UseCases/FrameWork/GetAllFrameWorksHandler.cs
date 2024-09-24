using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Framework;
using Enterprise.Census.Management.Application.DTOs.Responses.Framework;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.FrameWork;
public class GetAllFrameWorksHandler : IRequestHandler<GetAllFrameWorksRequest, List<GetAllFrameWorksResponse>>
{
    private readonly IFrameWorkRepository _frameWorkRepository;
    private readonly IMapper _mapper;

    public GetAllFrameWorksHandler(IFrameWorkRepository frameWorkRepository, IMapper mapper)
    {
        _frameWorkRepository = frameWorkRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllFrameWorksResponse>> Handle(GetAllFrameWorksRequest request, CancellationToken cancellationToken)
    {
        var frameWorks = await _frameWorkRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllFrameWorksResponse>>(frameWorks);
    }
}
