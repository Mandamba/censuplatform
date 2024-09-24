namespace Enterprise.Census.Management.Application.DTOs.Responses.Framework;
public record GetAllFrameWorksResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllFrameWorksResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}