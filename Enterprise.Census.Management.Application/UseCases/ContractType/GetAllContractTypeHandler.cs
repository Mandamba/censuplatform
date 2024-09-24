using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.ContractType;
using Enterprise.Census.Management.Application.DTOs.Responses.ContractType;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

public class GetAllContractTypeHandler : IRequestHandler<GetAllContractTypesRequest, List<GetAllContractTypesResponse>>
{
    private readonly IContractTypeRepository _contractTypeRepository;
    private readonly IMapper _mapper;

    public GetAllContractTypeHandler(IContractTypeRepository contractTypeRepository, IMapper mapper)
    {
        _contractTypeRepository = contractTypeRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllContractTypesResponse>> Handle(GetAllContractTypesRequest request, CancellationToken cancellationToken)
    {
        var contractTypes = await _contractTypeRepository.GetAll(cancellationToken);
        var response = _mapper.Map<List<GetAllContractTypesResponse>>(contractTypes);

        return response;
    }
}
