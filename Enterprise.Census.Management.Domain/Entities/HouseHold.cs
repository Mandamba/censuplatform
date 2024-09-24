namespace Enterprise.Census.Management.Domain.Entities;
public class HouseHold : BaseEntity
{
    public bool IsMarried { get; set; }
    public long PersonId { get; set; }
    public virtual Person Person { get; set; }
    public int? NumberOfChildren { get; set; }
    public string? SpouseName { get; set; }
}