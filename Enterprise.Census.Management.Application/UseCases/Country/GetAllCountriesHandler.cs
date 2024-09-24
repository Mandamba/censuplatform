using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Country;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllCountriesHandler : IRequestHandler<GetAllCountriesRequest, List<GetAllCountriesResponse>>
{
    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public GetAllCountriesHandler(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllCountriesResponse>> Handle(GetAllCountriesRequest request, CancellationToken cancellationToken)
    {
        var countries = await _countryRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllCountriesResponse>>(countries);
    }
}
