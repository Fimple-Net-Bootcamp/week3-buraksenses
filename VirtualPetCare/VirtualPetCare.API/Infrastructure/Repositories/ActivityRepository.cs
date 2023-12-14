using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class ActivityRepository : IActivityRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public ActivityRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Activity?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Activities.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Activity> CreateAsync(Activity activity)
    {
        await _dbContext.Activities.AddAsync(activity);
        await _dbContext.SaveChangesAsync();
        return activity;
    }
}