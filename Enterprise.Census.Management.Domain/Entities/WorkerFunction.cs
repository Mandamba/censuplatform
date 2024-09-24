namespace Enterprise.Census.Management.Domain.Entities;
public class WorkerFunction : BaseEntity
{
    public long FunctionId { get; set; }
    public Function Function { get; set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; }
    public long PersonId { get; set; }
    public Person Person { get; set; }
    public long DurationYear { get; set; }
}