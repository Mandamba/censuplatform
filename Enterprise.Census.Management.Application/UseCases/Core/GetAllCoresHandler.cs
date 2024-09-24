using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Core;
using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Core;
public class GetAllCoresHandler : IRequestHandler<GetAllCoresRequest, List<GetAllCoresResponse>>
{
    private readonly ICoreRepository _coreRepository;
    private readonly IMapper _mapper;

    public GetAllCoresHandler(ICoreRepository coreRepository, IMapper mapper)
    {
        _coreRepository = coreRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllCoresResponse>> Handle(GetAllCoresRequest request, CancellationToken cancellationToken)
    {
        var cores = await _coreRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllCoresResponse>>(cores);
    }
}