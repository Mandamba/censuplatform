using Enterprise.Census.Management.Application.DTOs.Responses.WorkRegime;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkRegime;
public record CreateWorkRegimeRequest(string Name) : IRequest<CreateWorkRegimeResponse>;
