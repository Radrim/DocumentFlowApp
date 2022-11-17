using Core;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Database
{
    public class MongoDbUserModel
    {
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public string Login { get; set; }
        [BsonIgnoreIfDefault]
        public string Password { get; set; }
        [BsonIgnoreIfDefault]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public string Surname { get; set; }
        [BsonIgnoreIfDefault]
        public string Email { get; set; }
        [BsonIgnoreIfDefault]
        public string Phone { get; set; }
        [BsonIgnoreIfDefault]
        public string Role { get; set; }
        [BsonIgnoreIfDefault]
        public string? Department { get; set; }
        [BsonIgnoreIfDefault]
        public string? OGRN { get; set; }
        [BsonIgnoreIfDefault]
        public string? INN { get; set; }
        [BsonIgnoreIfDefault]
        public string? KPP { get; set; }
        [BsonIgnoreIfDefault]
        public string? Address { get; set; }
        [BsonIgnoreIfDefault]
        public string? HeadOfTheExecutiveCommitteeRT { get; set; }
        [BsonIgnoreIfDefault]
        public string? Director { get; set; }
        [BsonIgnoreIfDefault]
        public string? ProjectLeadEngineer { get; set; }
        [BsonIgnoreIfDefault]
        public string? NameDesignOrganization { get; set; }

        public MongoDbUserModel(string login, string password, string name, string surname, string email,
                                string phone, string role, string department)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Role = role;
            Department = department;
        }

        public MongoDbUserModel(string login, string password, string name, string surname, string email,
                                string phone, string role, string department, string ogrn, string inn,
                                string kpp, string address, string headOfTheExecutiveCommitteeRT)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Role = role;
            Department = department;
            OGRN = ogrn;
            INN = inn;
            KPP = kpp;
            Address = address;
            HeadOfTheExecutiveCommitteeRT = headOfTheExecutiveCommitteeRT;
        }

        public MongoDbUserModel(string login, string password, string name, string surname, string email,
                                string phone, string role, string department, string ogrn, string inn,
                                string kpp, string address, string director, string projectLeadEngineer, string nameDesignOrganization)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Role = role;
            Department = department;
            OGRN = ogrn;
            INN = inn;
            KPP = kpp;
            Address = address;
            Director = director;
            ProjectLeadEngineer = projectLeadEngineer;
            NameDesignOrganization = nameDesignOrganization;
        }
    }
}
