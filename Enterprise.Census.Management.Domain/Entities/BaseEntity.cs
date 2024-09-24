using System.ComponentModel.DataAnnotations;

namespace Enterprise.Census.Management.Domain.Entities;
public class BaseEntity
{
    [Key]
    public long Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}
