namespace Enterprise.Census.Management.Domain.Entities;
public class Carrear : BaseEntity
{
    public long FunctionId { get; set; }
    public virtual Function Function { get; set; }
    public long CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public int DurationYear { get; set; } 
    public long PersonId { get; set; }
    public Person Person { get; set; }
}