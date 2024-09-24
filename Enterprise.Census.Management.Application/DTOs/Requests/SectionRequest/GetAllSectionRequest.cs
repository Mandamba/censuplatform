using Enterprise.Census.Management.Application.DTOs.Responses.SectionResponse;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.SectionRequest;
public record GetAllSectionRequest : IRequest<List<GetAllSectionResponse>>
{
}
