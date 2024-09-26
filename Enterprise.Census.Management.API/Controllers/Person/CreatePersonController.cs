using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Requests.Person;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Person;

[ApiController]
[Route("api/[controller]")]
public class CreatePersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public CreatePersonController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    //[Authorize(Policy = "AdminOnly")]
    public async Task<ActionResult<CreatePersonResponse>> Create([FromBody]CreatePersonRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return BadRequest("Invalid request.");
        }
        var response = await _mediator.Send(request, cancellationToken);
        return response;
    }

    [HttpGet("getPersonByBi/{bi}")]
    public async Task<ActionResult<CreatePersonResponse>> GetPersonData(string bi)
    {
        if (string.IsNullOrWhiteSpace(bi))
        {
            return BadRequest("O número de identificação é obrigatório.");
        }

        try
        {
            var personData = await _mediator.Send(new GetPersonByIdentificationNumberRequest(bi));
            return Ok(personData);
        }
        catch (ArgumentException ex)
        {
            return BadRequest($"Erro: {ex.Message}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter dados: {ex.Message}");
        }
    }

}