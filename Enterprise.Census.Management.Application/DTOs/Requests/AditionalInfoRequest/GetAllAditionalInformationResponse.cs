using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
public record GetAllAditionalInformationRequest: IRequest<List<GetAllAditionalInformationResponse>>;
