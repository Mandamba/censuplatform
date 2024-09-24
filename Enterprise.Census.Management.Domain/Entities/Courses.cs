namespace Enterprise.Census.Management.Domain.Entities;
public class Courses : BaseEntity
{
    public string Course { get; set; }
    public int ConclusionYear { get; set; }
    public long PersonId { get; set; }
    public virtual Person Person { get; set; }

}