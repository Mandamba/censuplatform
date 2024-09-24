namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record GetAllLanguagesResponse
{
    public long Id { get; set; }
    public string Language { get; set; }

    public GetAllLanguagesResponse(long id, string language)
    {
        Id = id;
        Language = language;
    }
}