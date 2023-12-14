using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class PetRepository : IPetRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public PetRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Pet>> GetAllAsync()
    {
        return await _dbContext.Pets.ToListAsync();
    }

    public async Task<Pet?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Pets.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Pet> CreateAsync(Pet pet)
    {
        await _dbContext.Pets.AddAsync(pet);
        await _dbContext.SaveChangesAsync();
        return pet;
    }

    public async Task<Pet?> UpdateAsync(Guid id, Pet pet)
    {
        var updatingPet = await _dbContext.Pets.FirstOrDefaultAsync(x => x.Id == id);

        if (updatingPet == null)
            return null;

        _dbContext.Entry(updatingPet).CurrentValues.SetValues(pet);
        await _dbContext.SaveChangesAsync();
        return updatingPet;
    }
}