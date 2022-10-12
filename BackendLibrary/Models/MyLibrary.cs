using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace BackendLibrary.Models
{

    public class MyLibrary
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? id { get; set; }
        [BsonElement("Authorname")]
        public String? AuthorName { get; set; }
        [BsonElement("bookname")]
        public String? Name { get; set; }
        [BsonElement("rating")]
        public Double? Ratings { get; set; }
        [BsonElement("description")]
        public String? Description { get; set; }
        [BsonElement("isseries")]
        public bool? IsSeries { get; set; }
        [BsonElement("seriesname")]
        public String? SeriesName { get; set; }
        [BsonElement("bookseries")]
        public string[]? Series { get; set; }

    }
}
