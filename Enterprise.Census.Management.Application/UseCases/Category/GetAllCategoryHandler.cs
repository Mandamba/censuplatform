using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.Category;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class GetAllCategoryHandler : IRequestHandler<GetAllCategoriesRequest, List<GetAllCategoriesResponse>>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    public GetAllCategoryHandler()
    {}

    public GetAllCategoryHandler(IMapper mapper, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<List<GetAllCategoriesResponse>> Handle(GetAllCategoriesRequest request, CancellationToken cancellationToken)
    {
        var aditionalInformation = await _categoryRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllCategoriesResponse>>(aditionalInformation);
    }
}
