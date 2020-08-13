using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionsFunctions collectionsFunctions = new CollectionsFunctions();
            List<string> lst = new List<string>{ "mamas", "6", "lior", "mamas", "aram"};
            collectionsFunctions.ListOperations(ref lst);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==================");

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["scuba"] = 6;
            collectionsFunctions.DictionaryOperations(ref dict);
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"{item.Key} : { item.Value}");
            }

            Console.WriteLine("==================");

            Stack<DateTime> stack = new Stack<DateTime>();
            stack.Push(DateTime.Now);
            stack.Push(new DateTime(2020, 07, 08));
            
            collectionsFunctions.StackOperations(ref stack);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
