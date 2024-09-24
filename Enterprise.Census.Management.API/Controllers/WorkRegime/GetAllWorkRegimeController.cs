using Enterprise.Census.Management.Application.DTOs.Requests.WorkerStateRequest;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkRegime;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkRegime;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.WorkRegime;
[ApiController]
[Route("api/[controller]")]
public class GetAllWorkRegimeController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllWorkRegimeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllWorkRegimesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllWorkRegimesRequest(), cancellationToken);
        return Ok(response);
    }
}