using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Persistence;

public class VirtualPetCareDbContext : DbContext
{
    public VirtualPetCareDbContext(DbContextOptions<VirtualPetCareDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Pet> Pets { get; set; }

    public DbSet<Activity> Activities{ get; set; }

    public DbSet<HealthStatus> HealthStatusList { get; set; }

    public DbSet<Nutrition> Nutritions { get; set; }
}