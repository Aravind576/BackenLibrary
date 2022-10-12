using BackendLibrary.Models;

namespace BackendLibrary.Services
{
    public interface ILoginAuthentications
    {
        LoginCredentials? SignUp(string username, string password);
        
    }
}
