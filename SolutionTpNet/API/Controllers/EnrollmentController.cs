using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EnrollmentController : ControllerBase
{
    private readonly EnrollmentService _enrollmentService;

    public EnrollmentController(EnrollmentService enrollmentService)
    {
        _enrollmentService = enrollmentService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Enrollment>>> GetAll()
    {
        return await _enrollmentService.GetAllEnrollmentsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Enrollment>> GetById(int id)
    {
        var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);
        if (enrollment == null) return NotFound();
        return enrollment;
    }

    [HttpPost]
    public async Task<ActionResult> Add(Enrollment enrollment)
    {
        await _enrollmentService.AddEnrollmentAsync(enrollment);
        return CreatedAtAction(nameof(GetById), new { id = enrollment.Id }, enrollment);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Enrollment enrollment)
    {
        if (id != enrollment.Id) return BadRequest();
        await _enrollmentService.UpdateEnrollmentAsync(enrollment);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _enrollmentService.DeleteEnrollmentAsync(id);
        return NoContent();
    }
}