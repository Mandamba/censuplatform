using Enterprise.Census.Management.Application.DTOs.Responses.Department;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Department;
public record GetAllDepartmentRequest : IRequest<List<GetAllDepartmentResponse>>;