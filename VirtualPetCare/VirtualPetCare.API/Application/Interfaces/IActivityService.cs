using VirtualPetCare.API.Application.DTOs.Activity;

namespace VirtualPetCare.API.Application.Interfaces;

public interface IActivityService
{
    Task<RetrieveActivityRequestDto?> GetByIdAsync(Guid id);

    Task<CreateActivityRequestDto> CreateAsync(CreateActivityRequestDto requestDto);
}