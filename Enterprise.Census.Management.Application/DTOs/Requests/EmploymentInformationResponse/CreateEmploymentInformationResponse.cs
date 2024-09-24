using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentInformationResponse;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
public record CreateEmploymentInformationRequest(
    DateTime AdmissionDate,
    long PositionId,
    DateTime PositionEntranceDate,
    long DivisionId,
    long DirectionId,
    long CoreId,
    long CategoryId,
    long SubcategoryId,
    long JobGroupId,
    long ContractTypeId,
    long EmploymentBondId,
    long WorkRegimeId,
    long FrameworkId,
    long DepartmentId,
    long SectionId) : IRequest<CreateEmploymentInformationResponse>;

