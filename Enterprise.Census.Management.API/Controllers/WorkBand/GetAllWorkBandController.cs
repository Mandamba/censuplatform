using Enterprise.Census.Management.Application.DTOs.Requests.Position;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkBand;
using Enterprise.Census.Management.Application.DTOs.Responses.Subcategory;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkBand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.WorkBand;
[ApiController]
[Route("api/[controller]")]
public class GetAllWorkBandController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllWorkBandController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllWorkBandsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllWorkBandsRequest(), cancellationToken);
        return Ok(response);
    }
}