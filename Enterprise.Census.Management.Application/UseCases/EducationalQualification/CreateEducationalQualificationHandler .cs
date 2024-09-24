using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateEducationalQualificationHandler : IRequestHandler<CreateEducationalQualificationRequest, CreateEducationalQualificationResponse>
{
    private readonly IMapper _mapper;
    private readonly IEducationalQualificationRepository _educationalQualificationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateEducationalQualificationHandler(IMapper mapper, IEducationalQualificationRepository educationalQualificationRepository, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _educationalQualificationRepository = educationalQualificationRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateEducationalQualificationResponse> Handle(CreateEducationalQualificationRequest request, CancellationToken cancellationToken)
    {
        var educationalQualification = _mapper.Map<EducationalQualification>(request);
        _educationalQualificationRepository.Create(educationalQualification);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateEducationalQualificationResponse>(educationalQualification);
    }
}