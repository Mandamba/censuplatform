namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record GetAllProvinceResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllProvinceResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}