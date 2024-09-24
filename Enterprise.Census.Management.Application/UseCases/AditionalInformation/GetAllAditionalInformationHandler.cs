using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllAditionalInformationHandler : IRequestHandler<GetAllAditionalInformationRequest, List<GetAllAditionalInformationResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAditionalInformationRepository _aditionalInformationRepository;
    public GetAllAditionalInformationHandler(IMapper mapper,IUnitOfWork unitOfWork, IAditionalInformationRepository aditionalInformation)
    {
        _aditionalInformationRepository = aditionalInformation;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<List<GetAllAditionalInformationResponse>> Handle(GetAllAditionalInformationRequest request, CancellationToken cancellationToken)
    {
        var aditionalInformation = await _aditionalInformationRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllAditionalInformationResponse>>(aditionalInformation);
    }
}