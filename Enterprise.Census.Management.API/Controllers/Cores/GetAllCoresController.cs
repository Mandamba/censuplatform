using Enterprise.Census.Management.Application.DTOs.Requests.Core;
using Enterprise.Census.Management.Application.DTOs.Requests.Direction;
using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using Enterprise.Census.Management.Application.DTOs.Responses.Direction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Cores;

[Route("api/[controller]")]
[ApiController]
public class GetAllCoresController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllCoresController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllCoresResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllCoresRequest(), cancellationToken);
        return Ok(response);
    }
}