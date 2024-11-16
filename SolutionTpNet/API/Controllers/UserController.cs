using Microsoft.AspNetCore.Mvc;
using SharedModels.DTOs;
using BusinessLogic.Interfaces;
using AutoMapper;

public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpGet("{file}")]
    public async Task<IActionResult> GetUser(int file)
    {
        var user = await _userService.GetUserAsync(file);
        var userDto = _mapper.Map<UserDTO>(user);  // Usa AutoMapper para mapear las entidades a DTOs
        return Ok(userDto);
    }
}