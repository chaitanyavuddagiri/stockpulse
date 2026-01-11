namespace StockPulse.Core.Models;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class BsonCollectionAttribute(string collectionName) : Attribute
{
    public string CollectionName { get; } = collectionName;
}