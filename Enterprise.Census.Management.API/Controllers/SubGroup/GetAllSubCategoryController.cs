using Enterprise.Census.Management.Application.DTOs.Requests.Position;
using Enterprise.Census.Management.Application.DTOs.Requests.Subcategory;
using Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.SubGroup;

[ApiController]
[Route("api/[controller]")]
public class GetAllSubCategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllSubCategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllSubCategoriesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllSubCategoriesRequest(), cancellationToken);
        return Ok(response);
    }
}