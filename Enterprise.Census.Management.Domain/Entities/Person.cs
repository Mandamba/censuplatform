namespace Enterprise.Census.Management.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string IdentificationNumber { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Residence { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Province { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string IssuingPlace { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public string PhoneNumber { get; set; }
        public string UpdatedPhoneNumber { get; set; }
        public string Nif { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string AlternativeContact { get; set; }
        public string AlternativeContactName { get; set; }
        public string? AditionalInformation { get; set; }
        public virtual EmploymentInformation EmploymentInformation { get; set; }
        public virtual WorkZone WorkZone { get; set; }
        public virtual HouseHold HouseHold { get; set; } 
        public virtual PaymentInformation PaymentInformation { get; set; }
        public virtual EducationalQualification EducationalQualification { get; set; }
        public virtual ICollection<SpokenLanguages> SpokenLanguages { get; set; } = new List<SpokenLanguages>();
        public virtual ICollection<WorkerFunction> WorkerFunctions { get; set; } = new List<WorkerFunction>();
        public virtual ICollection<AiditionalTraining> AiditionalTraining { get; set; } = new List<AiditionalTraining>();
    }
}
