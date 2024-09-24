using Enterprise.Census.Management.Application.DTOs.Request.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.Framework;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Responses.Framework;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.FrameWork;
[ApiController]
[Route("api/[controller]")]
public class GetAllFrameWorkController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllFrameWorkController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllFrameWorksResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllFrameWorksRequest(), cancellationToken);
        return Ok(response);
    }
}
