using Enterprise.Census.Management.Application.DTOs.Requests.EmploymentInformationRequest;
using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentInformationResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.EmploymentInformation;

[ApiController]
[Route("api/[controller]")]
public class CreateEmploymentInformationController : ControllerBase
{
    private readonly IMediator _mediator;

    public CreateEmploymentInformationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateEmploymentInformationResponse>> Create([FromBody] CreateEmploymentInformationRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Invalid request.");
        }
        var response = await _mediator.Send(request, cancellationToken);
        return response;
    }

}