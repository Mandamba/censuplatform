using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Function;
using Enterprise.Census.Management.Application.DTOs.Responses.Function;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Funtion;
public class GetAllFunctionsHandler : IRequestHandler<GetAllFunctionsRequest, List<GetAllFunctionsResponse>>
{
    private readonly IFunctionRepository _functionRepository;
    private readonly IMapper _mapper;

    public GetAllFunctionsHandler(IFunctionRepository functionRepository, IMapper mapper)
    {
        _functionRepository = functionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllFunctionsResponse>> Handle(GetAllFunctionsRequest request, CancellationToken cancellationToken)
    {
        var functions = await _functionRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllFunctionsResponse>>(functions);
    }
}