using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerCondition;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerStateRequest;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCondition;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerStateResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.WorkerState;
[ApiController]
[Route("api/[controller]")]
public class GetAllWorkerStateController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllWorkerStateController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllWorkerStatesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllWorkerStatesRequest(), cancellationToken);
        return Ok(response);
    }
}