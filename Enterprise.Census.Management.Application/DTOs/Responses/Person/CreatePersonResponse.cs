using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentInformationResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Responses.SpokenLanguage;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCarrear;

namespace Enterprise.Census.Management.Application.DTOs.Responses.Person
{
    public record CreatePersonResponse
    {
        public long Id { get; set; }
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
        public CreateEmploymentInformationResponse CreateEmploymentInformation { get; set; }
        public CreateWorkZoneResponse CreateWorkZone { get; set; }
        public CreatePaymentInformationResponse CreatePaymentInformation { get; set; }
        public CreateEducationalQualificationResponse CreateEducational { get; set; }
        public CreateWorkerCarrearResponse CreateWorkerCarrears { get; set; }
        public CreateHouseHoldResponse CreateHouseHold { get; set; }
        public string AditionalInformation { get; set; }
        public string UserName { get; set; }
        public long UserId { get; set; }

        public CreatePersonResponse() { }
        public CreatePersonResponse(
            long id,
            string identificationNumber,
            string fullName,
            string fatherName,
            string motherName,
            string residence,
            string placeOfBirth,
            string province,
            DateTimeOffset dateOfBirth,
            string gender,
            string issuingPlace,
            DateTimeOffset expirationDate,
            string phoneNumber,
            string updatedPhoneNumber,
            string nif,
            string socialSecurityNumber,
            string alternativeContact,
            string alternativeContactName,
            CreateEmploymentInformationResponse createEmploymentInformation,
            CreateWorkZoneResponse createWorkZone,
            CreatePaymentInformationResponse createPaymentInformation,
            CreateEducationalQualificationResponse createEducational,
            CreateWorkerCarrearResponse createWorkerCarrears,
            string aditionalInformation,
            string userName,
            long userId,
            CreateHouseHoldResponse createHouseHold)
        {
            Id = id;
            IdentificationNumber = identificationNumber;
            FullName = fullName;
            FatherName = fatherName;
            MotherName = motherName;
            Residence = residence;
            PlaceOfBirth = placeOfBirth;
            Province = province;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            IssuingPlace = issuingPlace;
            ExpirationDate = expirationDate;
            PhoneNumber = phoneNumber;
            UpdatedPhoneNumber = updatedPhoneNumber;
            Nif = nif;
            SocialSecurityNumber = socialSecurityNumber;
            AlternativeContact = alternativeContact;
            AlternativeContactName = alternativeContactName;
            CreateEmploymentInformation = createEmploymentInformation;
            CreateWorkZone = createWorkZone;
            CreatePaymentInformation = createPaymentInformation;
            CreateEducational = createEducational;
            CreateWorkerCarrears = createWorkerCarrears;
            AditionalInformation = aditionalInformation;
            UserName = userName;
            UserId = userId;
            CreateHouseHold = createHouseHold;
        }
    }
}
