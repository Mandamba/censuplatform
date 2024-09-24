using Enterprise.Census.Management.Application.DTOs.Requests.Direction;
using Enterprise.Census.Management.Application.DTOs.Responses.Direction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllDirectionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GetAllDirectionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllDirectionsResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllDirectionsRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
