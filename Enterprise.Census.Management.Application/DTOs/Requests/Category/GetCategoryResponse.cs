using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Responses.Category;
public record GetCategoryRequest : IRequest<GetCategoryResponse>;
