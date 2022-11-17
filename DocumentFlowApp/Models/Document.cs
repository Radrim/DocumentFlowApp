using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DocumentFlowApp.Models
{
    public class Document
    {
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public string FileName { get; set; }
        public string NameOfDocument { get; set; }

        public Document(string NameOfDocument) 
        {
            this.NameOfDocument = NameOfDocument;
        }
    }
}
