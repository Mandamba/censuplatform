using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Country;
public record GetAllCountriesRequest : IRequest<List<GetAllCountriesResponse>>;