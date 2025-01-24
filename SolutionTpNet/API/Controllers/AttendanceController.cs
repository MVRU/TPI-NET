using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AttendanceController : ControllerBase
{
    private readonly AttendanceService _attendanceService;

    public AttendanceController(AttendanceService attendanceService)
    {
        _attendanceService = attendanceService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Attendance>>> GetAll()
    {
        return await _attendanceService.GetAllAttendancesAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Attendance>> GetById(int id)
    {
        var attendance = await _attendanceService.GetAttendanceByIdAsync(id);
        if (attendance == null) return NotFound();
        return attendance;
    }

    [HttpPost]
    public async Task<ActionResult> Add(Attendance attendance)
    {
        await _attendanceService.AddAttendanceAsync(attendance);
        return CreatedAtAction(nameof(GetById), new { id = attendance.Id }, attendance);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Attendance attendance)
    {
        if (id != attendance.Id) return BadRequest();
        await _attendanceService.UpdateAttendanceAsync(attendance);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _attendanceService.DeleteAttendanceAsync(id);
        return NoContent();
    }
}