using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateCountryHandler : IRequestHandler<CreateCountryRequest, CreateCountryResponse>
{
    private readonly ICountryRepository _countryRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateCountryHandler(ICountryRepository countryRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateCountryResponse> Handle(CreateCountryRequest request, CancellationToken cancellationToken)
    {
        var country = _mapper.Map<Country>(request);
        var createdCountry = _countryRepository.Create(country);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateCountryResponse>(createdCountry);
    }
}
