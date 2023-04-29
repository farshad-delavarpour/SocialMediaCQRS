using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Core.Events
{
    public class EventModel
    {
        // These 2 attributes is for specifying this Id as the _id in mongoDB (object id)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid AggregateIdentifier { get; set; }
        public string AggregateType { get; set; }
        public int Version { get; set; }
        public string EventType { get; set; }
        public BaseEvent EventData { get; set; }
    }
}