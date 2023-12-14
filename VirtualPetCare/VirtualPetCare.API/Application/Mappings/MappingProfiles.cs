using AutoMapper;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Application.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, CreateUserRequestDto>().ReverseMap();
    }
}