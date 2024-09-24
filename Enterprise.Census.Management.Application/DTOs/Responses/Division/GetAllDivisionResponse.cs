namespace Enterprise.Census.Management.Application.DTOs.Responses.Division;
public record GetAllDivisionsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllDivisionsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
