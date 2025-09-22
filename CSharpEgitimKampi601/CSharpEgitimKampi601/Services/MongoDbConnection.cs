using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;
        public MongoDbConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017"); //MongoDB bağlantı adresi
            _database = client.GetDatabase("Db601Customer"); //Veritabanı ismi
              
        }
        public IMongoCollection<BsonDocument> GetCusomerCollection()
        {
            return _database.GetCollection<BsonDocument>("Customers"); //“Customers” koleksiyonuna erişip işlemler yapmamı sağlıyor

        }

    }
}
