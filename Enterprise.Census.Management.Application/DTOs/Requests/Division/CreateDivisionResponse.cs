using Enterprise.Census.Management.Application.DTOs.Responses.Division;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Division;
public record CreateDivisionRequest(string Name) : IRequest<CreateDivisionResponse>;
