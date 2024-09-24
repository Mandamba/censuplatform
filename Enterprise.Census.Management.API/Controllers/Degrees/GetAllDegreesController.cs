using Enterprise.Census.Management.Application.DTOs.Requests.Core;
using Enterprise.Census.Management.Application.DTOs.Requests.Degree;
using Enterprise.Census.Management.Application.DTOs.Responses.Core;
using Enterprise.Census.Management.Application.DTOs.Responses.Degree;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Degrees;

[ApiController]
[Route("api/[controller]")]
public class GetAllDegreesController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllDegreesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllDegreesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllDegreesRequest(), cancellationToken);
        return Ok(response);
    }
}