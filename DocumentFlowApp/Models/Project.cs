using Core;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.AspNetCore.SignalR;

namespace DocumentFlowApp.Models
{
    public class Project
    {
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public int Number {get; set; }
        public UserData RespCustomer { get; set; }
        [BsonIgnoreIfDefault]
        public UserData RespDesigner { get; set; }
        [BsonIgnoreIfDefault]
        public UserData RespBuilder { get; set; }
        [BsonIgnoreIfDefault]
        public List<Document> Documents { get; set; } = new List<Document>();
        int count;
        
        public void GetCount() {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<Project>("Project");
            count = collection.Find(x => x.Id != null).ToList<Project>().Count();
        }
        public Project(UserData customer, UserData designer, UserData builder, List<Document> documents) 
        {
            GetCount();
            RespCustomer = customer;
            RespDesigner = designer;
            RespBuilder = builder;
            Documents = documents;
        }
        public Project(UserData customer, UserData designer, UserData builder)
        {
            GetCount();
            Number += count;
            RespCustomer = customer;
            RespDesigner = designer;
            RespBuilder = builder;
        }
    }
}
