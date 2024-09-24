using Enterprise.Census.Management.Application.DTOs.Responses.EmployerEntity;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EmployerEntity;
public record GetAllEmployerEntitiesRquest : IRequest<List<GetAllEmployerEntitiesResponse>>;
