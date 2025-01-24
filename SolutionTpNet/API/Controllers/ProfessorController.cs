using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ProfessorController : ControllerBase
{
    private readonly ProfessorService _professorService;
    public ProfessorController(ProfessorService professorService)
    {
        _professorService = professorService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Professor>>> GetAll()
    {
        return await _professorService.GetAllProfessorsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Professor>> GetById(int id)
    {
        var professor = await _professorService.GetProfessorByIdAsync(id);
        if (professor == null)
        {
            return NotFound();
        }
        return Ok(professor);
    }

    [HttpPost]
    public async Task<ActionResult> Add(Professor professor)
    {
        await _professorService.AddProfessorAsync(professor);
        return CreatedAtAction(nameof(GetById), new { id = professor.Id }, professor);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Professor professor)
    {
        if (id != professor.Id)
        {
            return BadRequest();
        }
        await _professorService.UpdateProfessorAsync(professor);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _professorService.DeleteProfessorAsync(id);
        return NoContent();
    }
}