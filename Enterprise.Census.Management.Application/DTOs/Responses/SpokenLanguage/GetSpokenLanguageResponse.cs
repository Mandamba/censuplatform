namespace Enterprise.Census.Management.Application.DTOs.Responses.SpokenLanguage;

public record GetSpokenLanguageResponse(
    long Id,
    long LanguageId,
    string LanguageName,
    long PersonId);
