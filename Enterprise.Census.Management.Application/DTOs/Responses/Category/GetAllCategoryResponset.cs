namespace Enterprise.Census.Management.Application.DTOs.Responses.Category;
public record GetAllCategoriesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllCategoriesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}


