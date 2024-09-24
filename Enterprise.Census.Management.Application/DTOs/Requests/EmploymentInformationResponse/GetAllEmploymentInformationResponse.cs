using Enterprise.Census.Management.Application.DTOs.Responses.Person.EmploymentInformation;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationResponse;
public record GetAllEmploymentInformationRequest : IRequest<List<GetAllEmployeementInformationResponse>>;
