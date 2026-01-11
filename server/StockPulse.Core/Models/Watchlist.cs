using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StockPulse.Core.Models;

[BsonCollection("watchlists")]
public class Watchlist : BaseEntity
{
    [BsonElement("userId")]
    public string UserId { get; set; } = string.Empty;

    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("description")]
    public string Description { get; set; } = string.Empty;

    [BsonElement("stockTickers")]
    public List<string> StockTickers { get; set; } = new List<string>();

    [BsonElement("isDefault")]
    public bool IsDefault { get; set; } = false;
}