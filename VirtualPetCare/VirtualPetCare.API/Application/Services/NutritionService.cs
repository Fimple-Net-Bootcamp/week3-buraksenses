using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class NutritionService : INutritionService
{
    
    private readonly INutritionRepository _nutritionRepository;
    private readonly IMapper _mapper;

    public NutritionService(INutritionRepository nutritionRepository, IMapper mapper)
    {
        _nutritionRepository = nutritionRepository;
        _mapper = mapper;
    }
    
    public async Task<List<RetrieveNutritionRequestDto>> GetAllAsync()
    {
        var nutritions = await _nutritionRepository.GetAllAsync();

        var nutritionsDto = _mapper.Map<List<RetrieveNutritionRequestDto>>(nutritions);

        return nutritionsDto;
    }

    public async Task<CreateNutritionRequestDto> FeedPetAsync(Guid petId, CreateNutritionRequestDto requestDto)
    {
        
    }
}