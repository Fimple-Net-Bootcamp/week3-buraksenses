using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IActivityRepository
{
    Task<Activity?> GetByIdAsync(Guid id);

    Task<Activity> CreateAsync(Activity activity);
}