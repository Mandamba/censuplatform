using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AditionalTrainingController : ControllerBase
{
    private readonly IMediator _mediator;
    public AditionalTrainingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateAiditionalTrainingResponse>> Create(CreateAiditionalTrainingRequest request
        , CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}