using Enterprise.Census.Management.Application.DTOs.Responses.ContractType;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.ContractType;
public record GetAllContractTypesRequest : IRequest<List<GetAllContractTypesResponse>>;

