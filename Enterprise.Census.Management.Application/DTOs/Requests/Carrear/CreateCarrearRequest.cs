using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record CreateCarrearRequest(long FunctionId, long CategoryId, int DurationYear, long PersonId) : IRequest<CreateCarrearResponse>;