using Enterprise.Census.Management.Application.DTOs.Requests.Department;
using Enterprise.Census.Management.Application.DTOs.Responses.Department;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Department;
[Route("api/[controller]")]
[ApiController]
public class GetAllDepartmentController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllDepartmentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllDepartmentResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllDepartmentRequest(), cancellationToken);
        return Ok(response);
    }
}
