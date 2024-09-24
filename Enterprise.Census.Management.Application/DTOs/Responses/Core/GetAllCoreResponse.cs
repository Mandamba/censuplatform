namespace Enterprise.Census.Management.Application.DTOs.Responses.Core;
public record GetAllCoresResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllCoresResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}

