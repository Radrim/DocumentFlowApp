using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Reflection.Metadata;

namespace Database
{
    public class MongoDb
    {
        public static void AddUserToDataBase(MongoDbUserModel user) 
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<MongoDbUserModel>("Users");
            collection.InsertOne(user);
        }
        public static async Task UploadDocumentToDbAsync(Stream fs, string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var gridFS = new GridFSBucket(database);

            await gridFS.UploadFromStreamAsync(name, fs);
        }

        public List<string> GetNamesOfDocuments()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<GridFSFileInfo>("fs.files");
            var names = new List<string>();
            var documents = collection.Find(x => x.Filename != null).ToList<GridFSFileInfo>();

            foreach (var document in documents)
            {
                names.Add(document.Filename);
            }

            return names;
        }
    }
}