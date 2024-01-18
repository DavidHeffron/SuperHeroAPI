namespace UdemyAPI.Dtos.User
{
    public class UserLoginDto
    {
        //we created this dto even though it is the same as user register dto because register could eventaully have more fields while login will keep just 2
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
