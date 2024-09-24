namespace Enterprise.Census.Management.Domain.Entities;
public class WorkerCondition : BaseEntity
{
    public string Name { get; set; }
    public long WoerkerStateId { get; set; }
    public WorkerState WorkerState { get; set; }
}
