namespace Enterprise.Census.Management.Application.DTOs.Responses.EmploymentInformationResponse
{
    public record CreateEmploymentInformationResponse
    {
        public long Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public long PositionId { get; set; }
        public string PositionName { get; set; }
        public DateTime PositionEntranceDate { get; set; }
        public long DivisionId { get; set; }
        public string DivisionName { get; set; }
        public long DirectionId { get; set; }
        public string DirectionName { get; set; }
        public long CoreId { get; set; }
        public string CoreName { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public long SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public long JobGroupId { get; set; }
        public string JobGroupName { get; set; }
        public long ContractTypeId { get; set; }
        public string ContractTypeName { get; set; }
        public long EmploymentBondId { get; set; }
        public string EmploymentBondName { get; set; }
        public long WorkRegimeId { get; set; }
        public string WorkRegimeName { get; set; }
        public long FrameworkId { get; set; }
        public string FrameworkName { get; set; }
        public long EmployerEntityId { get; set; }
        public string EmployerEntityName { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public CreateEmploymentInformationResponse() { }
        public CreateEmploymentInformationResponse(
            long id,
            DateTime admissionDate,
            long positionId,
            string positionName,
            DateTime positionEntranceDate,
            long divisionId,
            string divisionName,
            long directionId,
            string directionName,
            long coreId,
            string coreName,
            long categoryId,
            string categoryName,
            long subcategoryId,
            string subcategoryName,
            long jobGroupId,
            string jobGroupName,
            long contractTypeId,
            string contractTypeName,
            long employmentBondId,
            string employmentBondName,
            long workRegimeId,
            string workRegimeName,
            long frameworkId,
            string frameworkName,
            long employerEntityId,
            string employerEntityName,
            long personId,
            string personName)
        {
            Id = id;
            AdmissionDate = admissionDate;
            PositionId = positionId;
            PositionName = positionName;
            PositionEntranceDate = positionEntranceDate;
            DivisionId = divisionId;
            DivisionName = divisionName;
            DirectionId = directionId;
            DirectionName = directionName;
            CoreId = coreId;
            CoreName = coreName;
            CategoryId = categoryId;
            CategoryName = categoryName;
            SubcategoryId = subcategoryId;
            SubcategoryName = subcategoryName;
            JobGroupId = jobGroupId;
            JobGroupName = jobGroupName;
            ContractTypeId = contractTypeId;
            ContractTypeName = contractTypeName;
            EmploymentBondId = employmentBondId;
            EmploymentBondName = employmentBondName;
            WorkRegimeId = workRegimeId;
            WorkRegimeName = workRegimeName;
            FrameworkId = frameworkId;
            FrameworkName = frameworkName;
            EmployerEntityId = employerEntityId;
            EmployerEntityName = employerEntityName;
            PersonId = personId;
            PersonName = personName;
        }
    }
}
