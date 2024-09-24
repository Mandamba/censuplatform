using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateAditionalTrainingHandler : IRequestHandler<CreateAiditionalTrainingRequest, CreateAiditionalTrainingResponse>
{
    private readonly IMapper _mapper;
    private readonly IAditionalTrainingRepository _aditionalTraining;
    private readonly IUnitOfWork _unitOfWork;
    public CreateAditionalTrainingHandler(IMapper mapper, IUnitOfWork unitOfWork,
        IAditionalTrainingRepository aditionalInformationRepository)
    {
        _mapper = mapper;
        _aditionalTraining = aditionalInformationRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<CreateAiditionalTrainingResponse> Handle(CreateAiditionalTrainingRequest request, CancellationToken cancellationToken)
    {
        var training = _mapper.Map<AiditionalTraining>(request);
        _aditionalTraining.Create(training);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateAiditionalTrainingResponse>(training);
    }
}