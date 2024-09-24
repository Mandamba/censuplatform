using Enterprise.Census.Management.Application.DTOs.Responses.Degree;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Degree;
public record GetDegreeRequest : IRequest<GetDegreeResponse>;
