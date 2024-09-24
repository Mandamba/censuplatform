using Enterprise.Census.Management.Application.DTOs.Requests.Function;
using Enterprise.Census.Management.Application.DTOs.Responses.Function;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Functions;

[Route("api/[controller]")]
[ApiController]
public class GetAllFunctionsController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllFunctionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllFunctionsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllFunctionsRequest(), cancellationToken);
        return Ok(response);
    }
}
