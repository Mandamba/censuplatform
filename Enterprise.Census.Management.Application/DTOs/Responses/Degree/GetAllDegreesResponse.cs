namespace Enterprise.Census.Management.Application.DTOs.Responses.Degree;
public record GetAllDegreesResponse 
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllDegreesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}