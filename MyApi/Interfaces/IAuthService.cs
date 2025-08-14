using MyApi.Models;

namespace MyApi.Interfaces
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user);
        User? ValidateUser(string username, string password);
    }
}
