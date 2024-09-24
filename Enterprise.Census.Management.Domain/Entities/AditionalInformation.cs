namespace Enterprise.Census.Management.Domain.Entities;
public class AditionalInformation : BaseEntity
{
    public string Description { get; set; } 
    public long PersonId { get; set; }
    public Person Person { get; set; }
} 
