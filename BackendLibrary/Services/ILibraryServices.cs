using BackendLibrary.Models;

namespace BackendLibrary.Services
{
    public interface ILibraryServices
    {
        List<MyLibrary> Get();
        List<MyLibrary> Get(string bookId);
        void edit(string bookid, double ratings);
        void delete(string bookid);
        
        
    }
}
