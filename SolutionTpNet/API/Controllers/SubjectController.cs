using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubjectController : ControllerBase
{
    private readonly SubjectService _subjectService;

    public SubjectController(SubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Subject>>> GetAll()
    {
        return await _subjectService.GetAllSubjectsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Subject>> GetById(int id)
    {
        var subject = await _subjectService.GetSubjectByIdAsync(id);
        if (subject == null) return NotFound();
        return subject;
    }

    [HttpPost]
    public async Task<ActionResult> Add(Subject subject)
    {
        await _subjectService.AddSubjectAsync(subject);
        return CreatedAtAction(nameof(GetById), new { id = subject.Id }, subject);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Subject subject)
    {
        if (id != subject.Id) return BadRequest();
        await _subjectService.UpdateSubjectAsync(subject);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _subjectService.DeleteSubjectAsync(id);
        return NoContent();
    }
}