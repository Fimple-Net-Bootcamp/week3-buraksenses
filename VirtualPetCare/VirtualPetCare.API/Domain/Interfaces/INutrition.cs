using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface INutrition
{
    Task<List<Nutrition>> GetAllAsync();

    Task CreateAsync(Nutrition nutrition);
}