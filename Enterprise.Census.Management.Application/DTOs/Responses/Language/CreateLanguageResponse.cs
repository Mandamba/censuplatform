namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record CreateLanguageResponse
{
    public long Id { get; set; }
    public string Language { get; set; }
    public CreateLanguageResponse() { }
    public CreateLanguageResponse(long id, string language)
    {
        Id = id;
        Language = language;
    }
}
