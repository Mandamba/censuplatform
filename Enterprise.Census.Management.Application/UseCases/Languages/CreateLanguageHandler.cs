using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateLanguageHandler : IRequestHandler<CreateLanguageRequest, CreateLanguageResponse>
{
    private readonly ILanguagesRepository _languagesRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateLanguageHandler(ILanguagesRepository languagesRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _languagesRepository = languagesRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateLanguageResponse> Handle(CreateLanguageRequest request, CancellationToken cancellationToken)
    {
        var language = _mapper.Map<Languages>(request);
        var createdLanguage = _languagesRepository.Create(language);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateLanguageResponse>(createdLanguage);
    }
}