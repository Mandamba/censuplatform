using Enterprise.Census.Management.Application.DTOs.Responses.SpokenLanguage;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.SpokenLanguage;
public record CreateSpokenLanguageRequest(
    long Id,
    long LanguageId,
    long PersonId
    ) : IRequest<List<CreateSpokenLanguageResponse>>;

