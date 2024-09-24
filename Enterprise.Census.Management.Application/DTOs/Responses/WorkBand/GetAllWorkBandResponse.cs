namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkBand;
public record GetAllWorkBandsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllWorkBandsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}