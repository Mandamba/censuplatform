using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
public record GetAllPaymentInformationRequest : IRequest<List<GetAllPaymentInformationResponse>>;
