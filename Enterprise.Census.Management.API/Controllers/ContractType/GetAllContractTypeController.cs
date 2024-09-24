using Enterprise.Census.Management.Application.DTOs.Requests.ContractType;
using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.ContractType;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.ContractType;
[Route("api/[controller]")]
[ApiController]
public class GetAllContractTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public GetAllContractTypeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllContractTypesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllContractTypesRequest(), cancellationToken);
        return Ok(response);
    }
}
