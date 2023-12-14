using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IPetRepository
{
    Task<List<Pet>> GetAllAsync();
    
    Task<Pet> GetByIdAsync(Guid id);

    Task CreateAsync(CreatePetRequestDto createPetRequestDto);

    Task UpdateAsync(Guid id, UpdatePetRequestDto updatePetRequestDto);
}