using DocumentFlowApp.Models;
using MongoDB.Driver;

namespace DocumentFlowApp.Services
{
    public class ProjectService
    {
        public List<Project> projects { get; set; } = new List<Project> { };
        public void AddProjectToDataBase(Project project)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<Project>("Project");
            collection.InsertOne(project);
        }
        public Project FindProjectById(Project project)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<Project>("Project");
            return collection.Find(x => x.Id == project.Id).FirstOrDefault();
        }

        public Project FindProjectByNumber(int projectNum)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<Project>("Project");
            return collection.Find(x => x.Number == projectNum).FirstOrDefault();
        }

        public List<Project> GetAllProject()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<Project>("Project");

            List<Project> project = collection.Find(x => x.Id != null).ToList<Project>();
            return project;
        }
    }
}
