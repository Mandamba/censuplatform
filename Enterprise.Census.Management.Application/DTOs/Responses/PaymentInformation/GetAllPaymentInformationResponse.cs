namespace Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
public record GetAllPaymentInformationResponse(
        List<GetPaymentInformationResponse> PaymentInformationList
    );