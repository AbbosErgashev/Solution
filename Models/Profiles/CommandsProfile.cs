using AutoMapper;
using Solution.Dtos;

namespace Solution.Models.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<CommandCreatedDto, Command>();

            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandUpdateDto, Command>();
        }
    }
}