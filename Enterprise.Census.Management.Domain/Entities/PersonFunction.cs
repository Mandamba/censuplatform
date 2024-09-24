namespace Enterprise.Census.Management.Domain.Entities;
public class PersonFunction : BaseEntity
{
    public long FunctionId { get; set; }
    public virtual Function Function { get; set; }
    public long PersonId { get; set; }
    public virtual Person Person { get; set; }
    public long CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public int DurationYear { get; set; }
}
