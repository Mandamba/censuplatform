using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.Department;
using Enterprise.Census.Management.Application.DTOs.Responses.Department;
using Enterprise.Census.Management.Application.DTOs.Responses.Direction;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.Department;
public class GetAllDepartmentHandler : IRequestHandler<GetAllDepartmentRequest, List<GetAllDepartmentResponse>>
{
    private readonly IMapper _mapper;
    private readonly IDepartmentRepository _departmentRepository;

    public GetAllDepartmentHandler(IMapper mapper, 
        IDepartmentRepository departmentRepository)
    {
        _mapper = mapper;
        _departmentRepository = departmentRepository;
    }
    public async Task<List<GetAllDepartmentResponse>> Handle(GetAllDepartmentRequest request, CancellationToken cancellationToken)
    {
        var department = await _departmentRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllDepartmentResponse>>(department);
    }
}
