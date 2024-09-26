using Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
using Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerCarrear;
using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record CreatePersonRequest(
    string IdentificationNumber,
    string FullName,
    string FatherName,
    string MotherName,
    string Residence,
    string PlaceOfBirth,
    string Province,
    DateTime DateOfBirth,
    string Gender,
    string IssuingPlace,
    DateTime ExpirationDate,
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

