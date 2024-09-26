namespace Enterprise.Census.Management.Domain.Entities;
public class SpokenLanguages : BaseEntity
{
    public long LanguageId { get; set; }
    public virtual Languages Language { get; set; }
    public virtual Person Person { get; set; }
    public long PersonId { get; set; }
}
