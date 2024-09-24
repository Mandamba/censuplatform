namespace Enterprise.Census.Management.Application.DTOs.Responses.SpokenLanguage;
public record CreateSpokenLanguageResponse
{
    public long Id { get; set; }
    public long LanguageId { get; set; }
    public string LanguageName { get; set; }
    public long PersonId { get; set; }
    public string PersonName { get; set; }
    public CreateSpokenLanguageResponse() { }
    public CreateSpokenLanguageResponse(
        long id,
        long languageId,
        string languageName,
        long personId,
        string personName)
    {
        Id = id;
        LanguageId = languageId;
        LanguageName = languageName;
        PersonId = personId;
        PersonName = personName;
    }
}
