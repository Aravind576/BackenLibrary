using BackendLibrary.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System.Drawing;

namespace BackendLibrary.Services
{
    public class LibraryServices : ILibraryServices
    {
        private readonly IMongoCollection<MyLibrary> _Library;

        public LibraryServices(IMyLibrarydatabaseSettings settings, IMongoClient mongoClient)
        {
            var _database = mongoClient.GetDatabase(settings.MyLibraryDatabaseName);
            _Library =_database.GetCollection<MyLibrary>(settings.DatabaseCollectionName);
            
            
        }
        public List<MyLibrary> Get()
        {
            return _Library.Find(books => true).ToList();
        }
        public List<MyLibrary> Get(string bookId)
        {
            return _Library.Find(key => key.id == bookId).ToList(); 
        }
        public void edit(string bookid, double ratings)
        {
            if (ratings > 5)
            {
                var library = _Library.Find(key => key.id == bookid).FirstOrDefault();
                library.Ratings = ratings;
                _Library.ReplaceOne(Key => Key.id == bookid, library);
                //_Library.UpdateOne(
                //    (Key => Key.id == bookid)
                //    , 
                //    ating: ratings 
                //);
                //db.student.updateOne({ name: "Annu"}, {$set: { age: 25} })
            }
        }
        public void delete(string bookid)
        {
            _Library.DeleteOne(Key => Key.id == bookid);
        }
    }
}
