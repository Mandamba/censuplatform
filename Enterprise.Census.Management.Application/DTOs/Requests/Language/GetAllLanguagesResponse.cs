using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Language;
public record GetAllLanguagesRequest : IRequest<List<GetAllLanguagesResponse>>;
