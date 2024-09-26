using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetPersonByIdentificationNumber : IRequestHandler<GetPersonByIdentificationNumberRequest, CreatePersonResponse>
{
    private readonly IMapper _mapper;
    private readonly IPersonRepository _personRepository;

    public GetPersonByIdentificationNumber(IMapper mapper, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
    }

    public async Task<CreatePersonResponse> Handle(GetPersonByIdentificationNumberRequest request, CancellationToken cancellationToken)
    {
        var existingPerson = await _personRepository.GetPersonByBI(request.identificationNumber, cancellationToken);

        if (existingPerson == null)
        {
            throw new Exception("Nenhuma pessoa encontrada com este número de identificação.");
        }
        return _mapper.Map<CreatePersonResponse>(existingPerson);
    }
}
