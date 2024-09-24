using Enterprise.Census.Management.Application.DTOs.Requests.Country;
using Enterprise.Census.Management.Application.DTOs.Requests.Division;
using Enterprise.Census.Management.Application.DTOs.Responses.Country;
using Enterprise.Census.Management.Application.DTOs.Responses.Division;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllDivisionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GetAllDivisionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllDivisionsResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllDivisionsRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
