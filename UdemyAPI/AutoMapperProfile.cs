using AutoMapper;
using UdemyAPI.Dtos.Character;

namespace UdemyAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //This will allow auto mapper to work and map characters to getcharacterDto
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();

        }
    }
}
