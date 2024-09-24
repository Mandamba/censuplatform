using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests.JobGroup;
using Enterprise.Census.Management.Application.DTOs.Requests.Subcategory;
using Enterprise.Census.Management.Application.DTOs.Responses.JobGroup;
using Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases.SubGroup;
public class GetAllSubCategoryHandler : IRequestHandler<GetAllSubCategoriesRequest, List<GetAllSubCategoriesResponse>>
{
    private readonly ISubCategoryRepository _subSubCategory;
    private readonly IMapper _mapper;
    public GetAllSubCategoryHandler(ISubCategoryRepository subGroupRepository, IMapper mapper)
    {
        _subSubCategory = subGroupRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllSubCategoriesResponse>> Handle(GetAllSubCategoriesRequest request, CancellationToken cancellationToken)
    {
        var subGroups = await _subSubCategory.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllSubCategoriesResponse>>(subGroups);
    }
}