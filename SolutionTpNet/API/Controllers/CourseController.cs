using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly CourseService _courseService;

    public CourseController(CourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Course>>> GetAll()
    {
        return await _courseService.GetAllCoursesAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Course>> GetById(int id)
    {
        var course = await _courseService.GetCourseByIdAsync(id);
        if (course == null) return NotFound();
        return course;
    }

    [HttpPost]
    public async Task<ActionResult> Add(Course course)
    {
        await _courseService.AddCourseAsync(course);
        return CreatedAtAction(nameof(GetById), new { id = course.Id }, course);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Course course)
    {
        if (id != course.Id) return BadRequest();
        await _courseService.UpdateCourseAsync(course);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _courseService.DeleteCourseAsync(id);
        return NoContent();
    }
}