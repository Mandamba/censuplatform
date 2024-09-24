namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerZone;
public record GetAllWorkZonesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllWorkZonesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
