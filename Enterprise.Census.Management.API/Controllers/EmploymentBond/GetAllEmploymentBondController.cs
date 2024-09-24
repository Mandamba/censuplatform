using Enterprise.Census.Management.Application.DTOs.Request.EmploymentBond;
using Enterprise.Census.Management.Application.DTOs.Requests.EmployerEntity;
using Enterprise.Census.Management.Application.DTOs.Responses.EmployerEntity;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.EmploymentBond;

[ApiController]
[Route("api/[controller]")]
public class GetAllEmploymentBondController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllEmploymentBondController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllEmploymentBondsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllEmploymentBondsRequest(), cancellationToken);
        return Ok(response);
    }
}