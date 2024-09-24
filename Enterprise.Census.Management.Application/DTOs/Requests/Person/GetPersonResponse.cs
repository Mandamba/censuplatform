using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Person;
public record GetPersonRequest : IRequest<GetPersonResponse>;
