using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerZone;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerZone;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GetAllWorkZoneController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllWorkZoneController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllWorkZonesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllWorkZonesRequest(), cancellationToken);
        return Ok(response);
    }
}