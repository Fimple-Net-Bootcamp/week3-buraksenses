using VirtualPetCare.API.Application.DTOs.HealthStatus;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IHealthStatusRepository
{
    Task<HealthStatus?> GetByIdAsync(Guid id);

    Task<HealthStatus?> UpdateAsync(Guid id, HealthStatus healthStatus);
}