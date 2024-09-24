namespace Enterprise.Census.Management.Domain.Entities;
public class EducationalQualification : BaseEntity
{
    public long DegreeId { get; set; }
    public virtual Degree Degree { get; set; }
    public string Course { get; set; }
    public DateTime StartDate { get; set; }
    public string Specialty { get; set; }
    public long ConclusionYear { get; set; }
    public long TrainingCountryId { get; set; }
    public virtual Country TrainingCountry { get; set; }
    public long PersonId { get; set; }
    public Person Person { get; set; }
    public virtual List<AiditionalTraining> AiditionalTraining { get; set; }
}
