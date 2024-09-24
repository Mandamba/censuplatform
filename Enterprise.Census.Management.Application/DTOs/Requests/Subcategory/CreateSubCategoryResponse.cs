using Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Subcategory;
public record CreateSubCategoryRequest(
    string Name) : IRequest<CreateSubCategoryResponse>;
