namespace Enterprise.Census.Management.Application.DTOs.Responses.SectionResponse;
public record GetAllSectionResponse
{
    public long Id { get; set; }
    public string Name { get; set; }
    public GetAllSectionResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
