using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Controllers.Core;

namespace VirtualPetCare.API.API.Controllers;

[Route("users")]
public class UsersController : BaseApiController
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var userDto = await _service.GetByIdAsync(id);

        if (userDto == null)
            return NotFound();

        return Ok(userDto);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateUserRequestDto requestDto)
    {
        await _service.CreateAsync(requestDto);

        return CreatedAtAction(nameof(GetById), requestDto);
    }
}