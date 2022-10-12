using BackendLibrary.Models;
using BackendLibrary.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        
        private readonly ILibraryServices _libraryServices;
        public LibraryController(ILibraryServices libraryServices)
        {
            _libraryServices = libraryServices;
        }
        // GET: api/<LibraryController>

        [HttpGet]
        public ActionResult<List<MyLibrary>> Get()
        {
            return _libraryServices.Get();
        }

        [HttpGet]
        [Route("Get/{bookid}")]
        public ActionResult<List<MyLibrary>> GetbyId(String bookid)
        {
            return _libraryServices.Get(bookid);
        }
        [HttpGet]
        [Route("edit/{bookid}/{ratings}")]
        public void edit(String bookid, double ratings)
        {
            _libraryServices.edit(bookid,ratings);
        }
        [HttpGet]
        [Route("delete/{bookid}")]
        public void delete(string bookid)
        {
            _libraryServices.delete(bookid);
        }

    }
}
