using UdemyAPI.Dtos.Character;

namespace UdemyAPI.Services.CharacterService
{
    public interface ICharacterService
    {
        //Refer to video 19 for reasoning behind service response
        //Makes it easier to standard api responses and easier to send error messages.
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(int userId);
        Task<ServiceResponse<GetCharacterDto>> GetCharacter(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}
