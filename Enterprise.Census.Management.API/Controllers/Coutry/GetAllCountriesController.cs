using Enterprise.Census.Management.Application.DTOs.Requests.Country;
using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllCountriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GetAllCountriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllCountriesResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllCountriesRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
