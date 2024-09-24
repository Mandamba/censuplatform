using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
using Enterprise.Census.Management.Application.DTOs.Responses.Category;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GetAllCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllCategoriesResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllCategoriesRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
