using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Request.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.ContractType;
using Enterprise.Census.Management.Application.DTOs.Requests.Core;
using Enterprise.Census.Management.Application.DTOs.Requests.Degree;
using Enterprise.Census.Management.Application.DTOs.Requests.Direction;
using Enterprise.Census.Management.Application.DTOs.Requests.Division;
using Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Requests.EmployerEntity;
using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationResponse;
using Enterprise.Census.Management.Application.DTOs.Requests.Framework;
using Enterprise.Census.Management.Application.DTOs.Requests.Function;
using Enterprise.Census.Management.Application.DTOs.Requests.JobGroup;
using Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Requests.Person;
using Enterprise.Census.Management.Application.DTOs.Requests.Position;
using Enterprise.Census.Management.Application.DTOs.Requests.SpokenLanguage;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerCarrear;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerFunction;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.Category;
using Enterprise.Census.Management.Application.DTOs.Responses.ContractType;
using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using Enterprise.Census.Management.Application.DTOs.Responses.Country;
using Enterprise.Census.Management.Application.DTOs.Responses.Degree;
using Enterprise.Census.Management.Application.DTOs.Responses.Department;
using Enterprise.Census.Management.Application.DTOs.Responses.Direction;
using Enterprise.Census.Management.Application.DTOs.Responses.Division;
using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Responses.EmployerEntity;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentInformationResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.Framework;
using Enterprise.Census.Management.Application.DTOs.Responses.Function;
using Enterprise.Census.Management.Application.DTOs.Responses.JobGroup;
using Enterprise.Census.Management.Application.DTOs.Responses.Language;
using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using Enterprise.Census.Management.Application.DTOs.Responses.Position;
using Enterprise.Census.Management.Application.DTOs.Responses.SectionResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.SpokenLanguage;
using Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkBand;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCarrear;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCondition;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerFunction;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkRegime;
using Enterprise.Census.Management.Application.UseCases;
using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AditionalInformation, CreateAditionalInformationResponse>()
           .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId));
        CreateMap<AditionalInformation, GetAditionalInformationResponse>()
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.PersonFullName, opt => opt.MapFrom(src => src.Person.FullName));
        CreateMap<CreateAditionalInformationRequest, AditionalInformation>();
        CreateMap<AditionalInformation, GetAllAditionalInformationResponse>();
        #region Carrear
        CreateMap<Carrear, CreateCarrearResponse>();
        CreateMap<CreateCarrearRequest, Carrear>();
        CreateMap<CreateWorkerCarrearRequest, CreateWorkerCarrearResponse>()
            .ForMember(dest => dest.Languages, opt => opt.MapFrom(src => src.Languages))
            .ForMember(dest => dest.Functions, opt => opt.MapFrom(src => src.Functions));
        #endregion
        #region AiditionalTraining
        CreateMap<AiditionalTraining, AiditionalTrainingResposne>();
        CreateMap<AiditionalTraining, CreateAiditionalTrainingResponse>();
        CreateMap<AiditionalTraining, CreateAiditionalTrainingResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course))
            .ForMember(dest => dest.CompletionYear, opt => opt.MapFrom(src => src.ConclusionYear))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId));

        CreateMap<CreateAiditionalTrainingRequest, AiditionalTraining>()
            .ForMember(dest => dest.ConclusionYear, opt => opt.MapFrom(src => src.CompletionYear));
        CreateMap<List<AiditionalTrainingResposne>, GetAllAiditionalTrainingResponse>()
            .ForMember(dest => dest.AiditionalTrainings, opt => opt.MapFrom(src => src));
        #endregion
        #region Courses
        CreateMap<Courses, GetCourseResponse>();
        CreateMap<Courses, CreateCourseResponse>();
        CreateMap<CreateCourseRquest, Courses>();
        #endregion
        #region Category
        CreateMap<Category, GetCategoryResponse>();
        CreateMap<Category, GetAllCategoriesResponse>();
        CreateMap<Category, CreateCategoryResponse>();
        CreateMap<CreateCategoryRequest, Category>();
        #endregion
        #region ContractType
        CreateMap<ContractType, ContractTypeResponse>();
        CreateMap<ContractType, CreateContractTypeResponse>();
        CreateMap<ContractType, GetAllContractTypesResponse>();
        CreateMap<CreateContractTypeRequest, ContractType>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<List<ContractTypeResponse>, GetAllContractTypesResponse>();
        #endregion
        #region Core
        CreateMap<Core, CreateCoreResponse>();
        CreateMap<Core, GetCoreResponse>();
        CreateMap<Core, GetAllCoresResponse>();
        CreateMap<CreateCoreRequest, Core>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<List<GetCoreResponse>, GetAllCoresResponse>();
        #endregion
        #region Country
        CreateMap<Country, CreateCountryResponse>();
        CreateMap<Country, GetCountriesResponse>();
        CreateMap<Country, GetAllCountriesResponse>();
        CreateMap<CreateCountryRequest, Country>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<List<GetCountriesResponse>, GetAllCountriesResponse>();
        #endregion
        #region Degree
        CreateMap<Degree, CreateDegreeResponse>();
        CreateMap<Degree, GetDegreeResponse>();
        CreateMap<Degree, GetAllDegreesResponse>();
        CreateMap<CreateDegreeRequest, Degree>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<List<GetDegreeResponse>, GetAllDegreesResponse>();
        #endregion
        #region Direction
        CreateMap<Direction, CreateDirectionResponse>();
        CreateMap<Direction, GetDirectionResponse>();
        CreateMap<Direction, GetAllDirectionsResponse>();
        CreateMap<CreateDirectionRequest, Direction>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<List<GetDirectionResponse>, GetAllDirectionsResponse>();
        #endregion
        #region Division
        CreateMap<Division, CreateDivisionResponse>();
        CreateMap<Division, GetAllDivisionsResponse>();
        CreateMap<Division, GetDivisionResponse>();
        CreateMap<CreateDivisionRequest, Division>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<List<GetDivisionResponse>, GetAllDivisionsResponse>();
        #endregion
        #region EducationalQualification
        CreateMap<EducationalQualification, CreateEducationalQualificationResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DegreeId, opt => opt.MapFrom(src => src.DegreeId))
            .ForMember(dest => dest.DegreeName, opt => opt.MapFrom(src => src.Degree.Name))
            .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course))
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.Specialty, opt => opt.MapFrom(src => src.Specialty))
            .ForMember(dest => dest.ConclusionYear, opt => opt.MapFrom(src => src.ConclusionYear))
            .ForMember(dest => dest.TrainingCountryId, opt => opt.MapFrom(src => src.TrainingCountryId))
            .ForMember(dest => dest.TrainingCountryName, opt => opt.MapFrom(src => src.TrainingCountry.Name))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName))
            .ForMember(dest => dest.CreateAiditionalTraining, opt => opt.MapFrom(src => src.AiditionalTraining));

        CreateMap<CreateAiditionalTrainingRequest, CreateAiditionalTrainingResponse>();

        CreateMap<EducationalQualification, GetEducationalQualificationResponse>()
            .ForMember(dest => dest.DegreeName, opt => opt.MapFrom(src => src.Degree.Name))
            .ForMember(dest => dest.TrainingCountryName, opt => opt.MapFrom(src => src.TrainingCountry.Name))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName));

        CreateMap<CreateEducationalQualificationRequest, EducationalQualification>()
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.AiditionalTraining, opt => opt.MapFrom(src => src.CreateAiditionalTraining));

        CreateMap<List<GetEducationalQualificationResponse>, GetAllEducationalQualificationsResponse>()
            .ForMember(dest => dest.EducationalQualifications, opt => opt.MapFrom(src => src));
        #endregion
        #region EmployerEntity
        CreateMap<EmployerEntity, CreateEmployerEntityResponse>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<EmployerEntity, GetEmployeerEntityResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<List<EmployerEntity>, GetAllEmployerEntitiesResponse>();
        CreateMap<EmployerEntity, GetAllEmployerEntitiesResponse>();

        CreateMap<CreateEmployerEntityRequest, EmployerEntity>()
            .ForMember(dest => dest.Name, opt => opt.Ignore());

        CreateMap<GetAllEmployerEntitiesRquest, List<EmployerEntity>>();

        CreateMap<GetEmployeerEntityRequest, EmployerEntity>();
        #endregion
        #region EmploymentBond
        CreateMap<EmploymentBond, CreateEmploymentBondResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<EmploymentBond, GetEmployeementBondResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<EmploymentBond, GetAllEmploymentBondsResponse>();

        CreateMap<CreateEmploymentBondRequest, EmploymentBond>()
            .ForMember(dest => dest.Name, opt => opt.Ignore());

        CreateMap<GetAllEmploymentBondsRequest, List<EmploymentBond>>();

        CreateMap<GetEmployeementBondRequest, EmploymentBond>();
        #endregion
        #region Employment Information
        CreateMap<EmploymentInformation, CreateEmploymentInformationResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.AdmissionDate, opt => opt.MapFrom(src => src.AdmissionDate))
            .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PositionId))
            .ForMember(dest => dest.PositionName, opt => opt.MapFrom(src => src.Position.Name))
            .ForMember(dest => dest.PositionEntranceDate, opt => opt.MapFrom(src => src.PositionEntranceDate))
            .ForMember(dest => dest.DivisionId, opt => opt.MapFrom(src => src.DivisionId))
            .ForMember(dest => dest.DivisionName, opt => opt.MapFrom(src => src.Division.Name))
            .ForMember(dest => dest.DirectionId, opt => opt.MapFrom(src => src.DirectionId))
            .ForMember(dest => dest.DirectionName, opt => opt.MapFrom(src => src.Direction.Name))
            .ForMember(dest => dest.CoreId, opt => opt.MapFrom(src => src.CoreId))
            .ForMember(dest => dest.CoreName, opt => opt.MapFrom(src => src.Core.Name))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.SubcategoryId, opt => opt.MapFrom(src => src.SubcategoryId))
            .ForMember(dest => dest.SubcategoryName, opt => opt.MapFrom(src => src.SubCategory.Name))
            .ForMember(dest => dest.JobGroupId, opt => opt.MapFrom(src => src.JobGroupId))
            .ForMember(dest => dest.JobGroupName, opt => opt.MapFrom(src => src.JobGroup.Name))
            .ForMember(dest => dest.ContractTypeId, opt => opt.MapFrom(src => src.ContractTypeId))
            .ForMember(dest => dest.ContractTypeName, opt => opt.MapFrom(src => src.ContractType.Name))
            .ForMember(dest => dest.EmploymentBondId, opt => opt.MapFrom(src => src.EmploymentBondId))
            .ForMember(dest => dest.EmploymentBondName, opt => opt.MapFrom(src => src.EmploymentBond.Name))
            .ForMember(dest => dest.WorkRegimeId, opt => opt.MapFrom(src => src.WorkRegimeId))
            .ForMember(dest => dest.WorkRegimeName, opt => opt.MapFrom(src => src.WorkRegime.Name))
            .ForMember(dest => dest.FrameworkId, opt => opt.MapFrom(src => src.FrameworkId))
            .ForMember(dest => dest.FrameworkName, opt => opt.MapFrom(src => src.FrameWork.Name)) 
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName));

        CreateMap<EmploymentInformation, GetEmploymentInformationResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.AdmissionDate, opt => opt.MapFrom(src => src.AdmissionDate))
            .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PositionId))
            .ForMember(dest => dest.PositionName, opt => opt.MapFrom(src => src.Position.Name))
            .ForMember(dest => dest.PositionEntranceDate, opt => opt.MapFrom(src => src.PositionEntranceDate))
            .ForMember(dest => dest.DivisionId, opt => opt.MapFrom(src => src.DivisionId))
            .ForMember(dest => dest.DivisionName, opt => opt.MapFrom(src => src.Division.Name))
            .ForMember(dest => dest.DirectionId, opt => opt.MapFrom(src => src.DirectionId))
            .ForMember(dest => dest.DirectionName, opt => opt.MapFrom(src => src.Direction.Name))
            .ForMember(dest => dest.CoreId, opt => opt.MapFrom(src => src.CoreId))
            .ForMember(dest => dest.CoreName, opt => opt.MapFrom(src => src.Core.Name))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.SubcategoryId, opt => opt.MapFrom(src => src.SubcategoryId))
            .ForMember(dest => dest.SubcategoryName, opt => opt.MapFrom(src => src.SubCategory.Name))
            .ForMember(dest => dest.JobGroupId, opt => opt.MapFrom(src => src.JobGroupId))
            .ForMember(dest => dest.JobGroupName, opt => opt.MapFrom(src => src.JobGroup.Name))
            .ForMember(dest => dest.ContractTypeId, opt => opt.MapFrom(src => src.ContractTypeId))
            .ForMember(dest => dest.ContractTypeName, opt => opt.MapFrom(src => src.ContractType.Name))
            .ForMember(dest => dest.EmploymentBondId, opt => opt.MapFrom(src => src.EmploymentBondId))
            .ForMember(dest => dest.EmploymentBondName, opt => opt.MapFrom(src => src.EmploymentBond.Name))
            .ForMember(dest => dest.WorkRegimeId, opt => opt.MapFrom(src => src.WorkRegimeId))
            .ForMember(dest => dest.WorkRegimeName, opt => opt.MapFrom(src => src.WorkRegime.Name))
            .ForMember(dest => dest.FrameworkId, opt => opt.MapFrom(src => src.FrameworkId))
            .ForMember(dest => dest.FrameworkName, opt => opt.MapFrom(src => src.FrameWork.Name))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName))
            .ForMember(dest => dest.SectionName, opt => opt.MapFrom(src => src.Section.Name))
            .ForMember(dest => dest.SecctionId, opt => opt.MapFrom(src => src.Section.Id))
            .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Department.Id))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Id));

        CreateMap<List<EmploymentInformation>, GetAllEmploymentInformationResponse>()
            .ForMember(dest => dest.EmploymentInformationList, opt => opt.MapFrom(src => src));

        CreateMap<CreateEmploymentInformationRequest, EmploymentInformation>()
            .ForMember(dest => dest.AdmissionDate, opt => opt.MapFrom(src => src.AdmissionDate))
            .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PositionId))
            .ForMember(dest => dest.PositionEntranceDate, opt => opt.MapFrom(src => src.PositionEntranceDate))
            .ForMember(dest => dest.DivisionId, opt => opt.MapFrom(src => src.DivisionId))
            .ForMember(dest => dest.DirectionId, opt => opt.MapFrom(src => src.DirectionId))
            .ForMember(dest => dest.CoreId, opt => opt.MapFrom(src => src.CoreId))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.SubcategoryId, opt => opt.MapFrom(src => src.SubcategoryId))
            .ForMember(dest => dest.JobGroupId, opt => opt.MapFrom(src => src.JobGroupId))
            .ForMember(dest => dest.ContractTypeId, opt => opt.MapFrom(src => src.ContractTypeId))
            .ForMember(dest => dest.EmploymentBondId, opt => opt.MapFrom(src => src.EmploymentBondId))
            .ForMember(dest => dest.WorkRegimeId, opt => opt.MapFrom(src => src.WorkRegimeId))
            .ForMember(dest => dest.FrameworkId, opt => opt.MapFrom(src => src.FrameworkId));

        CreateMap<GetAllEmploymentInformationRequest, List<EmploymentInformation>>();

        CreateMap<GetEmploymentInformationRequest, EmploymentInformation>();
        #endregion
        #region Framework
        CreateMap<FrameWork, CreateFrameWorkResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<FrameWork, GetFrameWorkResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<FrameWork, GetAllFrameWorksResponse>();

        CreateMap<CreateFrameWorkRequest, FrameWork>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<GetAllFrameWorksRequest, List<FrameWork>>();

        CreateMap<GetFrameWorkRequest, FrameWork>();
        #endregion
        #region Function
        CreateMap<CreateFunctionRquest, Function>()
            .ForMember(dest => dest.FunctionName, opt => opt.MapFrom(src => src.FunctionName));
        CreateMap<Function, CreateFunctionResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FunctionName, opt => opt.MapFrom(src => src.FunctionName));

        CreateMap<Function, GetFunctionResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FunctionName, opt => opt.MapFrom(src => src.FunctionName));
        CreateMap<Function, GetAllFunctionsResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FunctionName));

        #endregion
        #region JobGroup
        CreateMap<CreateJobGroupRequest, JobGroup>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<JobGroup, CreateJobGroupResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<JobGroup, GetJobGroupResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<JobGroup, GetAllJobGroupsResponse>();
        #endregion
        #region Language
        CreateMap<CreateLanguageRequest, Languages>()
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language));
        CreateMap<Languages, CreateLanguageResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language));

        CreateMap<Languages, GetLanguageResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language));
        CreateMap<Languages, GetAllLanguagesResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language));
        #endregion
        #region Payment Information
        CreateMap<CreatePaymentInformationRequest, PaymentInformation>();
        CreateMap<CreatePaymentInformationRequest, PaymentInformation>()
            .ForMember(dest => dest.IBAN, opt => opt.MapFrom(src => src.Iban))
            .ForMember(dest => dest.BankId, opt => opt.MapFrom(src => src.BankId))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode));

        CreateMap<PaymentInformation, CreatePaymentInformationResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Iban, opt => opt.MapFrom(src => src.IBAN))
            .ForMember(dest => dest.Bank, opt => opt.MapFrom(src => src.Bank.BankName))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName));

        CreateMap<PaymentInformation, GetPaymentInformationResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Iban, opt => opt.MapFrom(src => src.IBAN))
            .ForMember(dest => dest.Bank, opt => opt.MapFrom(src => src.Bank.BankName))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName));
        CreateMap<List<PaymentInformation>, GetAllPaymentInformationResponse>()
            .ForMember(dest => dest.PaymentInformationList, opt => opt.MapFrom(src => src));
        #endregion
        #region Person
        CreateMap<CreatePersonRequest, Person>()
            .ForMember(dest => dest.IdentificationNumber, opt => opt.MapFrom(src => src.IdentificationNumber))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
            .ForMember(dest => dest.FatherName, opt => opt.MapFrom(src => src.FatherName))
            .ForMember(dest => dest.MotherName, opt => opt.MapFrom(src => src.MotherName))
            .ForMember(dest => dest.Residence, opt => opt.MapFrom(src => src.Residence))
            .ForMember(dest => dest.PlaceOfBirth, opt => opt.MapFrom(src => src.PlaceOfBirth))
            .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.Province))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
            .ForMember(dest => dest.IssuingPlace, opt => opt.MapFrom(src => src.IssuingPlace))
            .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.UpdatedPhoneNumber, opt => opt.MapFrom(src => src.UpdatedPhoneNumber))
            .ForMember(dest => dest.Nif, opt => opt.MapFrom(src => src.Nif))
            .ForMember(dest => dest.SocialSecurityNumber, opt => opt.MapFrom(src => src.SocialSecurityNumber))
            .ForMember(dest => dest.AlternativeContact, opt => opt.MapFrom(src => src.AlternativeContact))
            .ForMember(dest => dest.AlternativeContactName, opt => opt.MapFrom(src => src.AlternativeContactName))
            .ForMember(dest => dest.PaymentInformation, opt => opt.MapFrom(src => src.CreatePaymentInformation))
            .ForMember(dest => dest.WorkZone, opt => opt.MapFrom(src => src.CreateWorkZone))
            .ForMember(dest => dest.EmploymentInformation, opt => opt.MapFrom(src => src.CreateEmploymentInformation))
            .ForMember(dest => dest.EducationalQualification, opt => opt.MapFrom(src => src.CreateEducational))
            .ForMember(dest => dest.SpokenLanguages, opt => opt.MapFrom(src => src.CreateWorkerCarrears.Languages))
            .ForMember(dest => dest.WorkerFunctions, opt => opt.MapFrom(src => src.CreateWorkerCarrears.Functions))
            .ForMember(dest => dest.HouseHold, opt => opt.MapFrom(src => src.CreateHouseHold))
            .ForMember(dest => dest.AditionalInformation, opt => opt.MapFrom(src => src.AditionalInformation));

        // Mapeamento de Entidade para Response
        CreateMap<Person, CreatePersonResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.IdentificationNumber, opt => opt.MapFrom(src => src.IdentificationNumber))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
            .ForMember(dest => dest.FatherName, opt => opt.MapFrom(src => src.FatherName))
            .ForMember(dest => dest.MotherName, opt => opt.MapFrom(src => src.MotherName))
            .ForMember(dest => dest.Residence, opt => opt.MapFrom(src => src.Residence))
            .ForMember(dest => dest.PlaceOfBirth, opt => opt.MapFrom(src => src.PlaceOfBirth))
            .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.Province))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
            .ForMember(dest => dest.IssuingPlace, opt => opt.MapFrom(src => src.IssuingPlace))
            .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.UpdatedPhoneNumber, opt => opt.MapFrom(src => src.UpdatedPhoneNumber))
            .ForMember(dest => dest.Nif, opt => opt.MapFrom(src => src.Nif))
            .ForMember(dest => dest.SocialSecurityNumber, opt => opt.MapFrom(src => src.SocialSecurityNumber))
            .ForMember(dest => dest.AlternativeContact, opt => opt.MapFrom(src => src.AlternativeContact))
            .ForMember(dest => dest.AlternativeContactName, opt => opt.MapFrom(src => src.AlternativeContactName))
            .ForMember(dest => dest.CreateEmploymentInformation, opt => opt.MapFrom(src => src.EmploymentInformation))
            .ForMember(dest => dest.CreateWorkZone, opt => opt.MapFrom(src => src.WorkZone))
            .ForMember(dest => dest.CreatePaymentInformation, opt => opt.MapFrom(src => src.PaymentInformation))
            .ForMember(dest => dest.CreateEducational, opt => opt.MapFrom(src => src.EducationalQualification)) 
            .ForPath(dest => dest.CreateWorkerCarrears.Languages, opt => opt.MapFrom(src => src.SpokenLanguages))
            .ForPath(dest => dest.CreateWorkerCarrears.Functions, opt => opt.MapFrom(src => src.WorkerFunctions))
            .ForPath(dest => dest.CreateEducational.CreateAiditionalTraining, opt => opt.MapFrom(src => src.AiditionalTraining));

        CreateMap<Person, GetPersonResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.IdentificationNumber, opt => opt.MapFrom(src => src.IdentificationNumber))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
            .ForMember(dest => dest.FatherName, opt => opt.MapFrom(src => src.FatherName))
            .ForMember(dest => dest.MotherName, opt => opt.MapFrom(src => src.MotherName))
            .ForMember(dest => dest.Residence, opt => opt.MapFrom(src => src.Residence))
            .ForMember(dest => dest.PlaceOfBirth, opt => opt.MapFrom(src => src.PlaceOfBirth))
            .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.Province))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
            .ForMember(dest => dest.IssuingPlace, opt => opt.MapFrom(src => src.IssuingPlace))
            .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.UpdatedPhoneNumber, opt => opt.MapFrom(src => src.UpdatedPhoneNumber))
            .ForMember(dest => dest.Nif, opt => opt.MapFrom(src => src.Nif))
            .ForMember(dest => dest.SocialSecurityNumber, opt => opt.MapFrom(src => src.SocialSecurityNumber))
            .ForMember(dest => dest.AlternativeContact, opt => opt.MapFrom(src => src.AlternativeContact))
            .ForMember(dest => dest.AlternativeContactName, opt => opt.MapFrom(src => src.AlternativeContactName));
        #endregion
        #region Position
        CreateMap<Position, GetAllPositionsResponse>();
        CreateMap<CreatePositionRequest, Position>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<Position, CreatePositionResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<Position, GetPositionResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        #endregion
        #region Spoken Language

        CreateMap<SpokenLanguages, CreateLanguageResponse>()
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Languages.Language))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LanguageId));
        CreateMap<SpokenLanguages, CreateSpokenLanguageResponse>()
            .ForMember(dest => dest.LanguageName, opt => opt.MapFrom(src => src.Languages.Language))
            .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId));

        CreateMap<CreateSpokenLanguageRequest, SpokenLanguages>()
            .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId));

        CreateMap<List<SpokenLanguages>, GetAllSpokenLanguagesResponse>()
        .ConvertUsing((src, dest, context) =>
                new GetAllSpokenLanguagesResponse(src.Select(x => context.Mapper.Map<GetSpokenLanguageResponse>(x)).ToList())
            );
        #endregion
        #region
        CreateMap<SubCategory, CreateSubCategoryResponse>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<SubCategory, GetSubCategoryResponse>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<SubCategory, GetAllSubCategoriesResponse>();
        #endregion
        #region FunctionPerson
        CreateMap<PersonFunction, CreatePersonFunctionResponse>()
            .ForMember(dest => dest.FunctionId, opt => opt.MapFrom(src => src.FunctionId))
            .ForMember(dest => dest.FunctionName, opt => opt.MapFrom(src => src.Function.FunctionName))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.DurationYear, opt => opt.MapFrom(src => src.DurationYear));

        CreateMap<CreatePersonFunctionRequest, PersonFunction>()
            .ForMember(dest => dest.FunctionId, opt => opt.MapFrom(src => src.FunctionId))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.DurationYear, opt => opt.MapFrom(src => src.DurationYear));
        #endregion
        #region WorkZone
        CreateMap<WorkZone, CreateWorkZoneResponse>()
           .ForMember(dest => dest.WorkerStateDesignation, opt => opt.MapFrom(src => src.WorkerState.Name))
           .ForMember(dest => dest.WorkerConditionName, opt => opt.MapFrom(src => src.WorkerCondition.Name))
           .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
           .ForMember(dest => dest.PersonFullName, opt => opt.MapFrom(src => src.Person.FullName));

        CreateMap<CreateWorkZoneRequest, WorkZone>()
            .ForMember(dest => dest.WorkerStateId, opt => opt.MapFrom(src => src.WorkerStateId))
            .ForMember(dest => dest.WorkerConditionId, opt => opt.MapFrom(src => src.WorkerConditionId));
        #endregion
        #region Worker Function
        CreateMap<WorkerFunction, CreateFunctionResponse>()
            .ForMember(dest => dest.FunctionName, opt => opt.MapFrom(src => src.Function.FunctionName));
        CreateMap<WorkerFunction, CreateWorkerFunctionResponse>()
            .ForMember(dest => dest.FunctionName, opt => opt.MapFrom(src => src.Function.FunctionName))
            .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        CreateMap<CreateWorkerFunctionRequest, WorkerFunction>()
            .ForMember(dest => dest.FunctionId, opt => opt.MapFrom(src => src.FunctionId))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.DurationYear, opt => opt.MapFrom(src => src.DurationYear));
        #endregion
        #region Person
        // Mapeamento de CreatePersonRequest para Person
        CreateMap<CreatePersonRequest, Person>()
            .ForMember(dest => dest.EmploymentInformation, opt => opt.MapFrom(src => src.CreateEmploymentInformation))
            .ForMember(dest => dest.WorkZone, opt => opt.MapFrom(src => src.CreateWorkZone))
            .ForMember(dest => dest.PaymentInformation, opt => opt.MapFrom(src => src.CreatePaymentInformation))
            .ForMember(dest => dest.EducationalQualification, opt => opt.MapFrom(src => src.CreateEducational))
            .ForMember(dest => dest.WorkerFunctions, opt => opt.MapFrom(src => src.CreateWorkerCarrears.Functions))
            .ForMember(dest => dest.SpokenLanguages, opt => opt.MapFrom(src => src.CreateWorkerCarrears.Languages))
            .ForMember(dest => dest.HouseHold, opt => opt.MapFrom(src => src.CreateHouseHold));


        // Mapeamento dos objetos aninhados
        CreateMap<CreateEmploymentInformationRequest, EmploymentInformation>();
        CreateMap<CreateWorkZoneRequest, WorkZone>();
        CreateMap<CreatePaymentInformationRequest, PaymentInformation>();

        // Mapeamento de CreateEducationalQualificationRequest para EducationalQualification
        CreateMap<CreateEducationalQualificationRequest, EducationalQualification>()
            .ForMember(dest => dest.AiditionalTraining, opt => opt.MapFrom(src => src.CreateAiditionalTraining));

        // Mapeamento de CreateAiditionalTrainingRequest para AiditionalTraining
        CreateMap<CreateAiditionalTrainingRequest, AiditionalTraining>();

        // Mapeamentos dos objetos aninhados
        CreateMap<CreateLanguageRequest, SpokenLanguages>();
        CreateMap<CreateWorkerFunctionRequest, WorkerFunction>(); // Supondo que CreateWorkerFunctionRequest é o DTO de entrada para WorkerFunction        #endregion
        #endregion
        #region Department
        CreateMap<Department, GetAllDepartmentResponse>();
        #endregion
        #region Section
        CreateMap<Section, GetAllSectionResponse>();
        #endregion
        #region Work Band
        CreateMap<WorkBand, GetAllWorkBandsResponse>();
        #endregion
        #region Privinces
        CreateMap<Province, GetAllProvinceResponse>();
        #endregion
        #region WorkerState
        CreateMap<WorkerState, GetAllWorkerStatesResponse>();
        #endregion
        #region WorkerCondition
        CreateMap<WorkerCondition, GetAllWorkerConditionsResponse>()
            .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.WorkerState != null ? src.WorkerState.Id : (long?)null))
            .ForMember(dest => dest.WorkerState, opt => opt.MapFrom(src => src.WorkerState != null ? src.WorkerState.Name : null));

        #endregion
        #region Bank Info
        CreateMap<Bank, GetAllBankResponse>();
        #endregion
        #region HouseHold
        CreateMap<HouseHold, CreateHouseHoldResponse>();
        CreateMap<CreateHouseHoldRequest, HouseHold>();
        #endregion
        #region User
        CreateMap<User, CreateUserResponse>();
        CreateMap<CreateUserRequest, User>();
        CreateMap<bool, CreateUserResponse>();
        #endregion
        #region WorkRegime
        CreateMap<WorkRegime, GetAllWorkRegimesResponse>();
        #endregion
        #region Worker Carrear
        // Mapeando a classe CreateWorkerFunctionRequest para a entidade Function
        CreateMap<CreateWorkerCarrearRequest, CreateWorkerCarrearResponse>()
            .ForMember(dest => dest.Languages, opt => opt.MapFrom(src => src.Languages))
            .ForMember(dest => dest.Functions, opt => opt.MapFrom(src => src.Functions));
        CreateMap<CreateWorkerCarrearRequest, CreateLanguageRequest>()
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Languages));
        #endregion
        #region AditionalTraining
        // Mapeando a classe CreateWorkerFunctionRequest para a entidade Function
        CreateMap<CreateAiditionalTrainingRequest, AiditionalTraining>()
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
            .ForMember(dest => dest.ConclusionYear, opt => opt.MapFrom(src => src.CompletionYear));
        #endregion
    }
}
