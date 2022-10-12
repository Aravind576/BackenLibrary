using MongoDB.Bson.Serialization.Attributes;

namespace BackendLibrary.Models
{
    public class LoginCredentials
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Userid { get; set; }
        [BsonElement("username")]
        public string? Username { get; set; }
        [BsonElement("password")]
        public string? Password { get; set; }    
    }
}
