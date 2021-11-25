using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Hash table");
            MymapNodes<string, string> hash = new MymapNodes<string, string>(5);
            hash.Add("0", "Arunesh");
            hash.Add("1", "Harshit");
            hash.Add("2", "Gaurav");
            hash.Add("3", "Raj");
            hash.Add("4", "Anshu");
            hash.Add("5", "Rishu");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:" + hash5);

            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value:" + hash2);
            Console.ReadLine();
        }
    }
}
