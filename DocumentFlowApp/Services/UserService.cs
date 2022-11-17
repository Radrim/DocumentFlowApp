using Core;
using Database;
using DocumentFlowApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using ZstdSharp.Unsafe;

namespace DocumentFlowApp.Services
{
    public class UserService
    {
        public UserData currentUser;
        public List<string> GetNamesOfDesignOrgs()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            List<string> names = collection.Find(x => x.NameDesignOrganization != null).ToList().Select(x => x.NameDesignOrganization).ToList<string>();

            return names;
        }

        public List<string> GetNamesOfBuilders()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            List<string> names = collection.Find(x => x.Role == "Застройщик").ToList().Select(x => x.Name).ToList<string>();

            return names;
        }

        public bool CheckUserLogin(UserData user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            if (collection.Find(x => x.Login == user.Login).FirstOrDefault() != null)
                return true;
            else return false;
        }

        public UserData FindUserByLogin(UserData user) 
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            return collection.Find(x => x.Login == user.Login).FirstOrDefault();
        }

        public UserData FindUserByNameOrgs(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            return collection.Find(x => x.NameDesignOrganization == name).FirstOrDefault();
        }

        public UserData FindUserByLogin(string Login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            return collection.Find(x => x.Login == Login).FirstOrDefault();
        }

        public UserData FindUserByName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");
            return collection.Find(x => x.Name == name).FirstOrDefault();
        }

        public void ReplaceUser(UserData user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("FlowDocumentAppData");
            var collection = database.GetCollection<UserData>("Users");

            collection.ReplaceOne(x => x.Login == user.Login, user);
        }

        public void ClearUser(UserData user)
        {
            user.Login = null;
            user.Password = null;
            user.Name = null;
            user.Surname = null;
            user.Email = null;
            user.Phone = null;
            user.Role = null;
            user.Department = null;
            user.OGRN = null;
            user.INN = null;
            user.KPP = null;
            user.Address = null;
            user.HeadOfTheExecutiveCommitteeRT = null;
            user.Director = null;
            user.ProjectLeadEngineer = null;
            user.NameDesignOrganization = null;
        }
    }
}
