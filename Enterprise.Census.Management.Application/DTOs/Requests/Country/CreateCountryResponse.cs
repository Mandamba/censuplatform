using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record CreateCountryRequest(string Name) : IRequest<CreateCountryResponse>;

