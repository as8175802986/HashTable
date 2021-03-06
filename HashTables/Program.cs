using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        public static void CountingWordFrequency(string sentence)            //this static method counts thr frquency of the words.
        {
            MymapNodes<string, int> hashtable = new MymapNodes<string, int>(10);      //declaring the key and value data types of the Mymapnodde class.
            string[] words = sentence.Split();                //splitting the sentence otherwise it wont be possible to generate keys.
            foreach (string word in words)
            {
                if (hashtable.Exists(word))                    //word is the "key"
                {
                    hashtable.Add(word, hashtable.Get(word) + 1);           //if it exists. get the value of the linkedlist object and invrement its value.
                }
                else
                {
                    hashtable.Add(word, 1);
                }
            }
            Console.WriteLine("Displaying after add operation\n");
            hashtable.Display();
            hashtable.Remove("avoidable");                                     //display after removing the key value pair with key avoidable
            Console.WriteLine("Displaying after removing avoidable.\n");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            CountingWordFrequency("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");



        }
    }
}
