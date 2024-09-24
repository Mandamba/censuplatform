using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Request.EmploymentBond;
public record GetAllEmploymentBondsRequest : IRequest<List<GetAllEmploymentBondsResponse>>;
