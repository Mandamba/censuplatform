namespace Enterprise.Census.Management.Application.DTOs.Responses.EmployerEntity;
public record GetAllEmployerEntitiesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllEmployerEntitiesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}