namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
public record GetAllWorkerStatesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllWorkerStatesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}