using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkRegime;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkRegime;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.WorkRegime;
public class GetAllWorkRegimesHandler : IRequestHandler<GetAllWorkRegimesRequest, List<GetAllWorkRegimesResponse>>
{
    private readonly IWorkRegimeRepository _workRegimeRepository;
    private readonly IMapper _mapper;

    public GetAllWorkRegimesHandler(IWorkRegimeRepository workRegimeRepository, IMapper mapper)
    {
        _workRegimeRepository = workRegimeRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllWorkRegimesResponse>> Handle(GetAllWorkRegimesRequest request, CancellationToken cancellationToken)
    {
        var workRegimes = await _workRegimeRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllWorkRegimesResponse>>(workRegimes);
    }
}