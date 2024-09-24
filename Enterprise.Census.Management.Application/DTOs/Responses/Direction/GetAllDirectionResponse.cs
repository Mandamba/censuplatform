namespace Enterprise.Census.Management.Application.DTOs.Responses.Direction;
public record GetAllDirectionsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllDirectionsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
