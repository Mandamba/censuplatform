using Enterprise.Census.Management.Application.DTOs.Requests.Position;
using Enterprise.Census.Management.Application.DTOs.Requests.SectionRequest;
using Enterprise.Census.Management.Application.DTOs.Responses.SectionResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Section;
[ApiController]
[Route("api/[controller]")]
public class SectionController : ControllerBase
{
    private readonly IMediator _mediator;
    public SectionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllSectionResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllSectionRequest(), cancellationToken);
        return Ok(response);
    }
}
