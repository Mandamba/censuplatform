using Enterprise.Census.Management.Application.DTOs.Requests.Person;
using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetPersonExternalDataHandler : IRequestHandler<GetPersonRequest, GetPersonResponse>
{
    public Task<GetPersonResponse> Handle(GetPersonRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}