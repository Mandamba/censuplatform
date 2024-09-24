using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AsitionalInformationController : ControllerBase
{
    private readonly IMediator _mediator;
    public AsitionalInformationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllAditionalInformationResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllAditionalInformationRequest(), cancellationToken);
        return Ok(response);
    }
}