using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Services;
using SharedModels.Models;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class AdminController : ControllerBase
{
    private readonly AdminService _adminService;
    public AdminController(AdminService adminService)
    {
        _adminService = adminService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Admin>>> GetAll()
    {
        return await _adminService.GetAllAdminsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Admin>> GetById(int id)
    {
        var admin = await _adminService.GetAdminByIdAsync(id);
        if (admin == null)
        {
            return NotFound();
        }
        return Ok(admin);
    }

    [HttpPost]
    public async Task<ActionResult> Add(Admin admin)
    {
        await _adminService.AddAdminAsync(admin);
        return CreatedAtAction(nameof(GetById), new { id = admin.Id }, admin);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Admin admin)
    {
        if (id != admin.Id)
        {
            return BadRequest();
        }
        await _adminService.UpdateAdminAsync(admin);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _adminService.DeleteAdminAsync(id);
        return NoContent();
    }
}