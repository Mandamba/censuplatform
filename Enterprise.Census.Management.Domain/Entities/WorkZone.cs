namespace Enterprise.Census.Management.Domain.Entities;
public class WorkZone : BaseEntity
{
    public string JobZone { get; set; }
    public string StudentWorker { get; set; }
    public long WorkerStateId { get; set; }
    public virtual WorkerState WorkerState { get; set; }
    public long WorkerConditionId { get; set; }
    public virtual WorkerCondition WorkerCondition { get; set; }
    public string DirectManager { get; set; }
    public Person Person { get; set; }
    public long PersonId { get; set; }
}
