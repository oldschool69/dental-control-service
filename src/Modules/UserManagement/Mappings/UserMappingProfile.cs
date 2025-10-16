using AutoMapper;
using UserManagement.DTOs;
using UserManagement.Entities;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<AppUser, UserDto>();
    }
}