using Enterprise.Census.Management.Application.DTOs.Requests.PaymentInformation;
using Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreatePaymentInformationController : ControllerBase
{
    private readonly IMediator _mediator;
     
    public CreatePaymentInformationController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<ActionResult<CreatePaymentInformationResponse>> Create([FromBody] CreatePaymentInformationRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Invalid request.");
        }

        var response = await _mediator.Send(request, cancellationToken);
        return response;
    }
}