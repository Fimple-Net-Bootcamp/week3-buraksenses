using VirtualPetCare.API.Application.DTOs.Nutrition;

namespace VirtualPetCare.API.Application.Interfaces;

public interface INutritionService
{
    Task<List<RetrieveNutritionRequestDto>> GetAllAsync();

    Task<CreateNutritionRequestDto> FeedPetAsync(Guid petId, CreateNutritionRequestDto requestDto);
}