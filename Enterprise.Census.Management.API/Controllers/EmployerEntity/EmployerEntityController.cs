using Enterprise.Census.Management.Application.DTOs.Requests.EmployerEntity;
using Enterprise.Census.Management.Application.DTOs.Responses.EmployerEntity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.EmployerEntity;
[Route("api/[controller]")]
[ApiController]
public class EmployerEntityController : ControllerBase
{
    private readonly IMediator _mediator;
    public EmployerEntityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllEmployerEntitiesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllEmployerEntitiesRquest(), cancellationToken);
        return Ok(response);
    }
}