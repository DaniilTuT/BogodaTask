using Application.Dtos.Person;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Api;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll([FromServices] PersonService personService)
    {
        var persons = personService.GetAll();
        return Ok(persons);
    }

    [HttpGet("GetById")]
    public IActionResult GetById([FromBody] PersonDeleteRequest request, [FromServices] PersonService personService)
    {
        var person = personService.GetById(request.Id);
        if (person == null)
            return NotFound();

        return Ok(person);
    }

    [HttpPost("Create")]
    public IActionResult Create([FromBody] PersonCreateRequest personDto, [FromServices] PersonService personService)
    {
        personService.Create(personDto);
        return Ok();
    }

    [HttpPut("Update")]
    public IActionResult Update([FromBody] PersonUpdateRequest personUpdateRequest,
        [FromServices] PersonService personService)
    {
        var updatedPerson = personService.Update(personUpdateRequest);
        return Ok(updatedPerson);
    }

    [HttpDelete("Delete")]
    public IActionResult Delete(Guid id, [FromServices] PersonService personService)
    {
        personService.Delete(id);
        return Ok();
    }
}