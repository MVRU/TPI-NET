using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ScheduleController : ControllerBase
{
    private readonly ScheduleService _scheduleService;

    public ScheduleController(ScheduleService scheduleService)
    {
        _scheduleService = scheduleService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Schedule>>> GetAll()
    {
        return await _scheduleService.GetAllSchedulesAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Schedule>> GetById(int id)
    {
        var schedule = await _scheduleService.GetScheduleByIdAsync(id);
        if (schedule == null) return NotFound();
        return schedule;
    }

    [HttpPost]
    public async Task<ActionResult> Add(Schedule schedule)
    {
        await _scheduleService.AddScheduleAsync(schedule);
        return CreatedAtAction(nameof(GetById), new { id = schedule.Id }, schedule);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Schedule schedule)
    {
        if (id != schedule.Id) return BadRequest();
        await _scheduleService.UpdateScheduleAsync(schedule);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _scheduleService.DeleteScheduleAsync(id);
        return NoContent();
    }
}