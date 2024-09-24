using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Language;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllLanguagesHandler : IRequestHandler<GetAllLanguagesRequest, List<GetAllLanguagesResponse>>
{
    private readonly ILanguagesRepository _languagesRepository;
    private readonly IMapper _mapper;

    public GetAllLanguagesHandler(ILanguagesRepository languagesRepository, IMapper mapper)
    {
        _languagesRepository = languagesRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllLanguagesResponse>> Handle(GetAllLanguagesRequest request, CancellationToken cancellationToken)
    {
        var languages = await _languagesRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllLanguagesResponse>>(languages);
    }
}