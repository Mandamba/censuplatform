namespace Enterprise.Census.Management.Application.DTOs.Responses.JobGroup;
public record GetAllJobGroupsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllJobGroupsResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}