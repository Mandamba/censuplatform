using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllBankHandler : IRequestHandler<GetAllBankRequest, List<GetAllBankResponse>>
{
    private readonly IBankRepository _bankRepository;
    private readonly IMapper _mapper;

    public GetAllBankHandler(IBankRepository bankRepository, IMapper mapper)
    {
        _bankRepository = bankRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllBankResponse>> Handle(GetAllBankRequest request, CancellationToken cancellationToken)
    {
        var banks = await _bankRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllBankResponse>>(banks);
    }
}
