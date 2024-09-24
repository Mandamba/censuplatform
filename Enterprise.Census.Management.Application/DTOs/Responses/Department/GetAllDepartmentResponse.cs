namespace Enterprise.Census.Management.Application.DTOs.Responses.Department;
public record GetAllDepartmentResponse 
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllDepartmentResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
