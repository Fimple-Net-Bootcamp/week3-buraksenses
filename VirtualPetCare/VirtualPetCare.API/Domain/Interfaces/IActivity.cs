using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IActivity
{
    Task<Activity> GetByIdAsync(Guid id);

    Task CreateAsync(CreateActivityRequestDto createActivityRequestDto);
}