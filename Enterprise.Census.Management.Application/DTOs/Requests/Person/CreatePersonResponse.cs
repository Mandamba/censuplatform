using Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
using Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerCarrear;
using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Person;
public record CreatePersonRequest(
    string IdentificationNumber,
    string FullName,
    string FatherName,
    string MotherName,
    string Residence,
    string PlaceOfBirth,
    string Province,
    DateTimeOffset DateOfBirth,
    string Gender,
    string IssuingPlace,
    DateTimeOffset ExpirationDate,
    string PhoneNumber,
    string UpdatedPhoneNumber,
    string Nif,
    string SocialSecurityNumber,
    string AlternativeContact,
    string AlternativeContactName,
    CreateEmploymentInformationRequest CreateEmploymentInformation,
    CreateWorkZoneRequest CreateWorkZone,
    CreatePaymentInformationRequest CreatePaymentInformation,
    CreateEducationalQualificationRequest CreateEducational,
    CreateWorkerCarrearRequest CreateWorkerCarrears,
    CreateHouseHoldRequest CreateHouseHold,
    string AditionalInformation
    ) : IRequest<CreatePersonResponse>;

