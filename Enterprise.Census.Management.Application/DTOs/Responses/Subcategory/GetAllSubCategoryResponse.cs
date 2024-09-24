namespace Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
public record GetAllSubCategoriesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllSubCategoriesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
