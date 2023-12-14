using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IUserRepository
{
    Task<User> GetByIdAsync(Guid id);

    Task CreateAsync(CreateUserRequestDto createUserRequestDto);
}