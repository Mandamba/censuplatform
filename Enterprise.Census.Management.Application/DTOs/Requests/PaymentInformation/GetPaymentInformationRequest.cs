using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
public record GetPaymentInformationRequest(
    long Id,
        string IBAN,
        string Bank,
        string CountryCode,
        long PersonId,
        string PersonName
    ): IRequest<GetPaymentInformationResponse>;