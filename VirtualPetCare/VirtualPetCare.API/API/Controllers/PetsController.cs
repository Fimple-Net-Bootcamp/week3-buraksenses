using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Controllers.Core;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v1/pets")]
public class PetsController : BaseApiController
{
    private readonly IPetService _service;
    public PetsController(IPetService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pets = await _service.GetAllAsync();

        return Ok(pets);
    }
}