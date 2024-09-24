using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
public record CreateAditionalInformationRequest(string Description, long PersonId) : IRequest<CreateAditionalInformationResponse>;

