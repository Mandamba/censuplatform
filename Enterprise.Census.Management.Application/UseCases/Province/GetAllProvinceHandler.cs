using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Province;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllProvinceHandler : IRequestHandler<GetAllProvinceRequest, List<GetAllProvinceResponse>>
{
    private readonly IProvinceRepository _provinceRepository;
    private readonly IMapper _mapper;

    public GetAllProvinceHandler(IProvinceRepository provinceRepository, IMapper mapper)
    {
        _provinceRepository = provinceRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllProvinceResponse>> Handle(GetAllProvinceRequest request, CancellationToken cancellationToken)
    {
        var provinces =await _provinceRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllProvinceResponse>>(provinces);
    }
}