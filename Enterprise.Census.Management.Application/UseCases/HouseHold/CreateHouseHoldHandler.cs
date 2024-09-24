using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateHouseHoldHandler : IRequestHandler<CreateHouseHoldRequest, CreateHouseHoldResponse>
{
    private readonly IHouseHoldRepository _houseHoldRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateHouseHoldHandler(IHouseHoldRepository houseHoldRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _houseHoldRepository = houseHoldRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateHouseHoldResponse> Handle(CreateHouseHoldRequest request, CancellationToken cancellationToken)
    {
        var mappedHouseHold = _mapper.Map<HouseHold>(request);
        _houseHoldRepository.Create(mappedHouseHold);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateHouseHoldResponse>(mappedHouseHold);
    }
}