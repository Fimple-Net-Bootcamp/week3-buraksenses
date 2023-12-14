using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Application.Mappings;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Infrastructure.Repositories;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddDbContext<VirtualPetCareDbContext>(options =>
        {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        services.AddAutoMapper(typeof(MappingProfiles).Assembly);

        services.AddScoped<IPetRepository, PetRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IActivityRepository, ActivityRepository>();
        services.AddScoped<INutritionRepository, NutritionRepository>();
        services.AddScoped<IHealthStatusRepository, HealthStatusRepository>();
        
        return services;
    }
}