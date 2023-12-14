﻿using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Application.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //USER MAPPINGS
        CreateMap<User, CreateUserRequestDto>().ReverseMap();

        CreateMap<User, RetrieveUserRequestDto>().ReverseMap();

        //PET MAPPINGS
        CreateMap<Pet, RetrievePetRequestDto>().ReverseMap();

        CreateMap<Pet, CreatePetRequestDto>().ReverseMap();

        CreateMap<Pet, UpdatePetRequestDto>().ReverseMap();
    }
}