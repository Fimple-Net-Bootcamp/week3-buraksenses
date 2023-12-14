using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Application.Mappings;
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

        return services;
    }
}