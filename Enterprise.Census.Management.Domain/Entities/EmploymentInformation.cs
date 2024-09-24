namespace Enterprise.Census.Management.Domain.Entities;
public class EmploymentInformation : BaseEntity
{
    public DateTime AdmissionDate { get; set; }
    public long PositionId { get; set; }
    public virtual Position Position { get; set; }
    public DateTime PositionEntranceDate { get; set; }
    public long DivisionId { get; set; }
    public virtual Division Division { get; set; }
    public long DirectionId { get; set; }
    public virtual Direction Direction { get; set; }
    public long CoreId { get; set; }
    public virtual Core Core { get; set; }
    public long CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public long SubcategoryId { get; set; }
    public virtual SubCategory SubCategory { get; set; }
    public long JobGroupId { get; set; }
    public virtual JobGroup JobGroup { get; set; }
    public long ContractTypeId { get; set; }
    public virtual ContractType ContractType { get; set; }
    public long EmploymentBondId { get; set; }
    public virtual EmploymentBond EmploymentBond { get; set; }
    public long WorkRegimeId { get; set; }
    public virtual WorkRegime WorkRegime { get; set; }
    public long FrameworkId { get; set; }
    public virtual FrameWork FrameWork { get; set; }
    //public long EmployerEntityId { get; set; }
    //public virtual EmployerEntity EmployerEntity { get; set; }
    public long SectionId { get; set; }
    public Section Section { get; set; }
    public long DepartmentId { get; set; }
    public Department Department { get; set; }
    public long PersonId { get; set; }
    public virtual Person Person { get; set; }
}
