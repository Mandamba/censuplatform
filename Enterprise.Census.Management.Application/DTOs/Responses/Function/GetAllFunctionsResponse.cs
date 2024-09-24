namespace Enterprise.Census.Management.Application.DTOs.Responses.Function;
public record GetAllFunctionsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }
    public GetAllFunctionsResponse() { }
    public GetAllFunctionsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}

