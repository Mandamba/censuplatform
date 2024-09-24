namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerCondition;
public record GetAllWorkerConditionsResponse
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long StateId { get; set; }
    public string WorkerState { get; set; }

    public GetAllWorkerConditionsResponse()
    {}

    public GetAllWorkerConditionsResponse(long id, 
        string name, long stateId, string workerState)
    {
        Id = id;
        Name = name;
        StateId = stateId;
        WorkerState = workerState;
    }
}