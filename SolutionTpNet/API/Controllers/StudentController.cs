using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StudentController : ControllerBase
{
    private readonly StudentService _studentService;
    public StudentController(StudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAll()
    {
        return await _studentService.GetAllStudentsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetById(int id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(student);
    }

    [HttpPost]
    public async Task<ActionResult> Add(Student student)
    {
        await _studentService.AddStudentAsync(student);
        return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Student student)
    {
        if (id != student.Id)
        {
            return BadRequest();
        }
        await _studentService.UpdateStudentAsync(student);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _studentService.DeleteStudentAsync(id);
        return NoContent();
    }
}