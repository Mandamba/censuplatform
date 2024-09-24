using Enterprise.Census.Management.Application.DTOs.Requests.Position;
using Enterprise.Census.Management.Application.DTOs.Responses.Position;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Position;
[ApiController]
[Route("api/[controller]")]
public class GetAllPositionController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllPositionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllPositionsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllPositionsRequest(), cancellationToken);
        return Ok(response);
    }
}