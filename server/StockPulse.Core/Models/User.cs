using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StockPulse.Core.Models;

[BsonCollection("users")]
public class User : BaseEntity
{
    [BsonElement("email")]
    public string Email { get; set; } = string.Empty;

    [BsonElement("passwordHash")]
    public string PasswordHash { get; set; } = string.Empty;

    [BsonElement("firstName")]
    public string FirstName { get; set; } = string.Empty;

    [BsonElement("lastName")]
    public string LastName { get; set; } = string.Empty;

    [BsonElement("isActive")]
    public bool IsActive { get; set; } = true;

    [BsonElement("watchlistIds")]
    public List<string> WatchlistIds { get; set; } = new List<string>();
}