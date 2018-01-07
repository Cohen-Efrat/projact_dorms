using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace projact_dorms.Models
{
    public class DBmanger
    {
        public String connectionString = "mongodb://localhost:27017";
        public String DataBaseName = "Dorms";

        public MongoDatabase Database;

        public DBmanger()
        {
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            Database = server.GetDatabase(DataBaseName);
        }
        public MongoCollection<ApprovalKit> ApprovalKit
        {
            get
            {
                var ApprovalKitcollaction = Database.GetCollection<ApprovalKit>("ApprovalKit");
                return ApprovalKitcollaction;
            }

        }

        public MongoCollection<User> Users
        {
            get
            {
                var Usercollaction = Database.GetCollection<User>("User");
                return Usercollaction;
            }

        }

        public MongoCollection<FaultForm> Fault
        {
            get
            {
                var Usercollaction = Database.GetCollection<User>("FaultForm");
                return Usercollaction;
            }

        }


    }
}