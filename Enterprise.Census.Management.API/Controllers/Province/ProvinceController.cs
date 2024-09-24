using Enterprise.Census.Management.Application.DTOs.Requests.Province;
using Enterprise.Census.Management.Application.DTOs.Requests.SectionRequest;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.SectionResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Province;

[ApiController]
[Route("api/[controller]")]
public class ProvinceController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProvinceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllProvinceResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllProvinceRequest(), cancellationToken);
        return Ok(response); 
    }
}