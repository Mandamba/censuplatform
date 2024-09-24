using Enterprise.Census.Management.Application.DTOs.Responses.Person.EmploymentInformation;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
public record GetEmploymentInformationRequest : IRequest<GetEmployeementInformationResponse>;
