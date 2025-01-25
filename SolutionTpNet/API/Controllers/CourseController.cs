using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using BusinessLogic.Interfaces;
using SharedModels.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    /// <summary>
    /// Obtiene todos los cursos.
    /// </summary>
    /// <returns>Una lista de cursos.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CourseResponse>>> GetAll()
    {
        var courses = await _courseService.GetAllCoursesAsync();
        return Ok(courses);
    }

    /// <summary>
    /// Obtiene un curso por su ID.
    /// </summary>
    /// <param name="id">El ID del curso.</param>
    /// <returns>El curso correspondiente al ID.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<CourseResponse>> GetById(int id)
    {
        var course = await _courseService.GetCourseByIdAsync(id);
        if (course == null) return NotFound();
        return Ok(course);
    }

    /// <summary>
    /// Crea un nuevo curso.
    /// </summary>
    /// <param name="course">Los datos del curso a crear.</param>
    /// <returns>El curso creado.</returns>
    [HttpPost]
    [Authorize(Roles = "Admin,Professor")]  // Solo los roles Admin y Professor pueden crear cursos
    public async Task<ActionResult<CourseResponse>> Add(CourseRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var course = await _courseService.AddCourseAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = course.Id }, course);
    }

    /// <summary>
    /// Actualiza un curso existente.
    /// </summary>
    /// <param name="id">El ID del curso a actualizar.</param>
    /// <param name="course">Los nuevos datos del curso.</param>
    /// <returns>Respuesta sin contenido.</returns>
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin,Professor")]  // Solo los roles Admin y Professor pueden actualizar cursos
    public async Task<ActionResult> Update(int id, CourseRequest request)
    {
        if (id != request.Id) return BadRequest("El ID del curso no coincide.");

        if (!ModelState.IsValid) return BadRequest(ModelState);

        await _courseService.UpdateCourseAsync(request);
        return NoContent();
    }

    /// <summary>
    /// Elimina el curso por su ID.
    /// </summary>
    /// <param name="id">El ID del curso a eliminar.</param>
    /// <returns>Respuesta sin contenido.</returns>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin,Professor")]  // Solo los roles Admin y Professor pueden eliminar cursos
    public async Task<ActionResult> Delete(int id)
    {
        await _courseService.DeleteCourseAsync(id);
        return NoContent();
    }
}