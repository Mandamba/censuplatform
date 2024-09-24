namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record GetAllCountriesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllCountriesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
