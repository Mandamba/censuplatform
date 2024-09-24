using Enterprise.Census.Management.Application.DTOs.Responses.WorkBand;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkBand;
public record CreateWorkBandRequest(string Name) : IRequest<CreateWorkBandResponse>;

