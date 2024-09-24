using Enterprise.Census.Management.Application.Interfaces;
using Enterprise.Census.Management.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Census.Management.API.Controllers.Person;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IExternalPersonService _externalPerson;
    private readonly IMediator _mediator;
    public PersonController(IExternalPersonService personService, IMediator mediator)
    {
        _externalPerson = personService;
        _mediator = mediator;
    }

    [HttpGet("{bi}")]
    public async Task<IActionResult> GetPersonData(string bi)
    {
        try
        {
            var personData = await _externalPerson.GetPersonDataFromApiAsync(bi);
            return Ok(personData);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter dados: {ex.Message}");
        }
    }
}