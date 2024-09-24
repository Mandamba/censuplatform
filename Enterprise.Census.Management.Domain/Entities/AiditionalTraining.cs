namespace Enterprise.Census.Management.Domain.Entities;
public class AiditionalTraining : BaseEntity
{
    public string Course { get; set; }
    public long ConclusionYear { get; set; }
    public long PersonId { get; set; }
    public virtual Person Person { get; set; }
}
