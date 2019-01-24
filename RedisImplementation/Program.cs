using System;
using StackExchange.Redis;
using Newtonsoft.Json;

namespace RedisImplementation
{
    class Program
    {
        public static IDatabase RedisConnection()
        {
            var redis = ConnectionMultiplexer.Connect("localhost");
            var db = redis.GetDatabase();

            return db;
        }

        public static string GetValue(string value)
        {
            var db = RedisConnection();
            return db.StringGet(value);
        }

        public static void SetValue()
        {
            var db = RedisConnection();
            db.StringSet("game", "pubg");
        }

        static void Main(string[] args)
        {
            string value = GetValue("name");

            var action = Console.ReadLine();
            if (action == "set")
            {
                SetValue();
            }
            Console.WriteLine("key : name , value : " + value);

            Console.ReadKey();
        }
    }
}
