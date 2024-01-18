namespace UdemyAPI.Data
{
    //First create interface
    //Then go to implementer class and inplement methods logic
    //Then implement the controller
    //Use DTOs in controller to control what fields should/shouldnt be sent over for certain requests and responses
    //Register the auth repo in program class
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExisits(string username);
    }
}
