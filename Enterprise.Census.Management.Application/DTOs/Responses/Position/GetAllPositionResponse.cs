namespace Enterprise.Census.Management.Application.DTOs.Responses.Position;
public record GetAllPositionsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllPositionsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}