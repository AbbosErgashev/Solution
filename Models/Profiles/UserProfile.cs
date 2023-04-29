using AutoMapper;
using Solution.Dtos.UserDtos;

namespace Solution.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreatedDto, User>();

            CreateMap<User, UserReadDto>();

            CreateMap<UserUpdateDto, User>();
        }
    }
}