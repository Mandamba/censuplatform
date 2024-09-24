using Enterprise.Census.Management.Application.DTOs.Requests.Language;
using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Languages;

[ApiController]
[Route("api/[controller]")]
public class LanguagesController : ControllerBase
{
    private readonly IMediator _mediator;
    public LanguagesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllLanguagesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllLanguagesRequest(), cancellationToken);
        return Ok(response);
    }
}