using Enterprise.Census.Management.Application.DTOs.Responses.Language;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Language;
public record GetLanguageRequest : IRequest<GetLanguageResponse>;
