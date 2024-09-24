using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;
using System.Net;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateAditionalInformationHandler : IRequestHandler<CreateAditionalInformationRequest, CreateAditionalInformationResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAditionalInformationRepository _aditionalInformationRepository;

    public CreateAditionalInformationHandler(IUnitOfWork unitOfWork, IMapper mapper,
        IAditionalInformationRepository aditionalInformationRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _aditionalInformationRepository = aditionalInformationRepository;
    }

    public async Task<CreateAditionalInformationResponse> Handle(CreateAditionalInformationRequest request, CancellationToken cancellationToken)
    {
        var aditionalInformation = _mapper.Map<AditionalInformation>(request);
        var createAditionalInformation = _aditionalInformationRepository.Create(aditionalInformation);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateAditionalInformationResponse>(createAditionalInformation);
    }
}