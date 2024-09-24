using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
public record CreatePaymentInformationRequest(
        long Id,
        string Iban,
        int BankId,
        string CountryCode) : IRequest<CreatePaymentInformationResponse>;
