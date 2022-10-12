using BackendLibrary.Models;
using BackendLibrary.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginAuthentications _LoginCredentials;
        public LoginController(ILoginAuthentications loginAuthentications)
        {
            _LoginCredentials = loginAuthentications;
        }
        // GET: api/<LoginController>
        [HttpGet]
        [Route("Signup /{username}/{password}")]
        public LoginCredentials? SignUp(string username,string password)
        {
            return _LoginCredentials.SignUp(username, password);
        }
    }
}
