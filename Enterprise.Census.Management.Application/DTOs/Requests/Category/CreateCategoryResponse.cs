using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Responses.Category;
public record CreateCategoryRequest(string Name) : IRequest<CreateCategoryResponse>;