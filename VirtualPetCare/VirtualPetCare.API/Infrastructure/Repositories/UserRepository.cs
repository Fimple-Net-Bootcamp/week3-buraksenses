using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public UserRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<User> GetByIdAsync(Guid id)
    {
        
    }

    public Task CreateAsync(CreateUserRequestDto createUserRequestDto)
    {
        return null;
    }
}