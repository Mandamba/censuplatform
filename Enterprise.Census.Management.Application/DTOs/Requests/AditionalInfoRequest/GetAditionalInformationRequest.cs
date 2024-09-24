using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.AditionalInfoRequest;
public record GetAditionalInformationRequest(
    long Id, string Description, long PersonId, string PersonFullName
    ) : IRequest<GetAditionalInformationResponse>;

