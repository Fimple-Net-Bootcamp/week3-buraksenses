using Microsoft.EntityFrameworkCore;

namespace VirtualPetCare.API.Persistence;

public class VirtualPetCareDbContext : DbContext
{
    public VirtualPetCareDbContext(DbContextOptions<VirtualPetCareDbContext> options) : base(options)
    {
        
    }
}