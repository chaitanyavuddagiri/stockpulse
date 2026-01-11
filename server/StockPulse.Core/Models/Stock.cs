using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StockPulse.Core.Models;

[BsonCollection("stocks")]
public class Stock : BaseEntity
{
    [BsonElement("ticker")]
    public string Ticker { get; set; } = string.Empty;

    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("price")]
    public decimal Price { get; set; }

    [BsonElement("change")]
    public decimal Change { get; set; }

    [BsonElement("changePercent")]
    public decimal ChangePercent { get; set; }

    [BsonElement("volume")]
    public long Volume { get; set; }

    [BsonElement("marketCap")]
    public long MarketCap { get; set; }

    [BsonElement("sector")]
    public string Sector { get; set; } = string.Empty;

    [BsonElement("industry")]
    public string Industry { get; set; } = string.Empty;

    [BsonElement("lastUpdated")]
    public DateTime LastUpdated { get; set; }
}