namespace Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
public record GetAllEmploymentBondsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllEmploymentBondsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}