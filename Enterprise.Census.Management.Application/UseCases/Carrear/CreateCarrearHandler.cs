using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreateCarrearHandler : IRequestHandler<CreateCarrearRequest, CreateCarrearResponse>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICarrearRepository _carrearRepository;

    public CreateCarrearHandler(IMapper mapper, IUnitOfWork unitOfWork, ICarrearRepository carrearRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _carrearRepository = carrearRepository;
    }

    public async Task<CreateCarrearResponse> Handle(CreateCarrearRequest request, CancellationToken cancellationToken)
    {
        var carrear = _mapper.Map<Carrear>(request);
        var createdCarrear = _carrearRepository.Create(carrear);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateCarrearResponse>(createdCarrear);
    }
}