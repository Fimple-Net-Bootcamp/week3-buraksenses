using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class HealthStatusRepository : IHealthStatusRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public HealthStatusRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<HealthStatus?> GetByIdAsync(Guid id)
    {
        return await _dbContext.HealthStatusList.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<HealthStatus?> UpdateAsync(Guid id, HealthStatus healthStatus)
    {
        var updatingStatus = await _dbContext.HealthStatusList.FirstOrDefaultAsync(x => x.Id == id);

        if (updatingStatus == null)
            return null;

        updatingStatus.Pet = healthStatus.Pet;
        updatingStatus.VaccinationStatus = healthStatus.VaccinationStatus;
        updatingStatus.Notes = healthStatus.Notes;
        updatingStatus.CheckupDate = healthStatus.CheckupDate;
        updatingStatus.PetId = healthStatus.PetId;

        return updatingStatus;
    }
}