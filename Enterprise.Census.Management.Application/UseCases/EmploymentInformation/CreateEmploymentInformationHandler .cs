using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentInformationResponse;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;

public class CreateEmploymentInformationHandler : IRequestHandler<CreateEmploymentInformationRequest, CreateEmploymentInformationResponse>
{
    private readonly IMapper _mapper;
    private readonly IEmploymentInformationRepository _employmentInformationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateEmploymentInformationHandler(IMapper mapper, IEmploymentInformationRepository employmentInformationRepository, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _employmentInformationRepository = employmentInformationRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateEmploymentInformationResponse> Handle(CreateEmploymentInformationRequest request, CancellationToken cancellationToken)
    {
        var employmentInformation = _mapper.Map<EmploymentInformation>(request);
        _employmentInformationRepository.Create(employmentInformation);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateEmploymentInformationResponse>(employmentInformation);
    }
}
