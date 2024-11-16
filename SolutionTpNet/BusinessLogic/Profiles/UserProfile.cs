using AutoMapper;
using DataAccess.Entities;
using SharedModels.DTOs;

namespace BusinessLogic.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap(); // Mapea User a UserDTO y viceversa
        }
    }
}