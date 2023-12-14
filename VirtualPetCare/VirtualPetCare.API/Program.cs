using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;
//
// try
// {
//     var context = services.GetRequiredService<VirtualPetCareDbContext>();
//     await context.Database.MigrateAsync();
// }
// catch (Exception e)
// {
//     Console.WriteLine(e);
//     throw;
// }

app.Run();