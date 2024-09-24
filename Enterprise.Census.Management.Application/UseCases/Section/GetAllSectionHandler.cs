using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.SectionRequest;
using Enterprise.Census.Management.Application.DTOs.Responses.SectionResponse;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Section;
public class GetAllSectionHandler : IRequestHandler<GetAllSectionRequest, List<GetAllSectionResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISectionRepository _sectionRepository;
    private readonly IMapper _mapper;

    public GetAllSectionHandler(IMapper mapper, IUnitOfWork unitOfWork, ISectionRepository sectionRepository)
    {
        _unitOfWork = unitOfWork;
        _sectionRepository = sectionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllSectionResponse>> Handle(GetAllSectionRequest request, CancellationToken cancellationToken)
    {
        var secctions = await _sectionRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllSectionResponse>>(secctions);
    }
}
