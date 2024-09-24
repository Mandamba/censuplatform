namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkRegime;
public record GetAllWorkRegimesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllWorkRegimesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
