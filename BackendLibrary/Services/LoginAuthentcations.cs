using BackendLibrary.Models;
using MongoDB.Driver;

namespace BackendLibrary.Services
{
    public class LoginAuthentcations : ILoginAuthentications
    {
        private readonly IMongoCollection<LoginCredentials> _Login;
        public LoginAuthentcations(ILoginCredentialsSettings settings,IMongoClient mongoClient)
        {
            var _database = mongoClient.GetDatabase(settings.LoginCredentialsDatabaseName);
            _Login = _database.GetCollection<LoginCredentials>(settings.DatabaseCollectionsName);
        }
        /// <summary>
        /// method to check the login credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginCredentials? SignUp(string username, string password)
        {
            var tempUsername=_Login.Find(key=>key.Username == username).FirstOrDefault();
            if(tempUsername == null)
            {
                return null;
                
            }
            else
            {
                if(tempUsername.Password == password)
                {
                    return tempUsername;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
