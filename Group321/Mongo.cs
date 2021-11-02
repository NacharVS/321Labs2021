using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Mongo
    {

            public Mongo(string name, int age, List<string> items)
            {
                this.name = name;
                this.age = age;
                this.items.AddRange(items);
            }
            public Mongo(string name, int age, int group)
            {
                this.name = name;
                this.age = age;
                this.Group = group;
            }

            [BsonId]
            [BsonIgnoreIfDefault]
            ObjectId _id;
            [BsonElement("Имя")]
            public string name { get; set; }
            public int age { get; set; }
            [BsonIgnoreIfDefault]
            public int Group { get; set; }
            public List<string> items = new List<string>();

            public static void AddToDataBase(Mongo person)
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("321gr2021brr");
                var collection = database.GetCollection<Mongo>("qqPerson");
                collection.InsertOne(person);
            }

            public static void FindFromDatabase()
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("321gr2021brr");
                var collection = database.GetCollection<Mongo>("qqPerson");
                var listPerson = collection.Find(x => x.name == "Oleg" && x.age == 12).ToList();
            foreach (Mongo item in listPerson)
            {
                Console.WriteLine($"{item.name}");
            }
           
            }
        public static void UpdateName(int newAge)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("321gr2021brr");
            var collection = database.GetCollection<Mongo>("qqPerson");
            collection.UpdateOne(x => x.name == "Mikhail", Builders<Mongo>.Update.Set(x => x.age, newAge));
            //collection.ReplaceOne(x => x.name == "Oleg", newPers);
        }

    }
}
