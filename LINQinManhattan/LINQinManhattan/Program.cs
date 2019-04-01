using System;
using Newtonsoft.Json;
using LINQinManhattan.Classes;

namespace LINQinManhattan
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LINQ in Manhattan");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Query();
            
        }

        public static void Query()
        {
            string filePath = System.IO.File.ReadAllText("../data.json");
            Data convert = JsonConvert.DeserializeObject<Data>(filePath);

            var jsonQuery = from 

        }
    }
}
