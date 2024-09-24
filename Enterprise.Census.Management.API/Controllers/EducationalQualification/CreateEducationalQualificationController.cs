using Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.EducationalQualification;

[ApiController]
[Route("api/[controller]")]
public class CreateEducationalQualificationController : ControllerBase
{
    private readonly IMediator _mediator;

    public CreateEducationalQualificationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateEducationalQualificationResponse>> Create(CreateEducationalQualificationRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Invalid request.");
        }
        var response = await _mediator.Send(request, cancellationToken);
        return response;
    }
}