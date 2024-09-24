using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreatePaymentInformationHandler : IRequestHandler<CreatePaymentInformationRequest, CreatePaymentInformationResponse>
{
    private readonly IMapper _mapper;
    private readonly IPaymentInformationRepository _paymentInformationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreatePaymentInformationHandler(IMapper mapper, IPaymentInformationRepository paymentInformationRepository, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _paymentInformationRepository = paymentInformationRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreatePaymentInformationResponse> Handle(CreatePaymentInformationRequest request, CancellationToken cancellationToken)
    {
        var paymentInformation = _mapper.Map<PaymentInformation>(request);
        _paymentInformationRepository.Create(paymentInformation);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreatePaymentInformationResponse>(paymentInformation);
    }
}