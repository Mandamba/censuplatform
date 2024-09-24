using Enterprise.Census.Management.Application.DTOs.Requests.Division;
using Enterprise.Census.Management.Application.DTOs.Requests.JobGroup;
using Enterprise.Census.Management.Application.DTOs.Responses.Division;
using Enterprise.Census.Management.Application.DTOs.Responses.JobGroup;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.JobGroup;

[Route("api/[controller]")]
[ApiController]
public class GetAllJobGroupsController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllJobGroupsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllJobGroupsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllJobGroupsRequest(), cancellationToken);
        return Ok(response);
    }
}