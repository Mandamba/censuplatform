using Enterprise.Census.Management.Application.DTOs.Requests.WorkerCondition;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerCondition;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.WorkerCondition;

[ApiController]
[Route("api/[controller]")]
public class GetAllWorkerConditionController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllWorkerConditionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllWorkerConditionsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllWorkerConditionsRequest(), cancellationToken);
        return Ok(response);
    }
}
