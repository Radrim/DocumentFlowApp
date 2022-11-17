using Core;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Xml.Linq;

namespace DocumentFlowApp.Models
{
    public class UserData
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
        public string Department { get; set; }
        [BsonIgnoreIfDefault]
        public string OGRN { get; set; }
        [BsonIgnoreIfDefault]
        public string INN { get; set; }
        [BsonIgnoreIfDefault]
        public string KPP { get; set; }
        [BsonIgnoreIfDefault]
        public string Address { get; set; }
        [BsonIgnoreIfDefault]
        public string HeadOfTheExecutiveCommitteeRT { get; set; }
        [BsonIgnoreIfDefault]
        public string Director { get; set; }
        [BsonIgnoreIfDefault]
        public string ProjectLeadEngineer { get; set; }
        [BsonIgnoreIfDefault]
        public string NameDesignOrganization { get; set; }
    }
}
