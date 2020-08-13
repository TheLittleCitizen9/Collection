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
            var newLst = collectionsFunctions.ListOperations(lst);
            foreach (var item in newLst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==================");

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["scuba"] = 6;
            var newDict = collectionsFunctions.DictionaryOperations(dict);
            foreach (KeyValuePair<string, int> item in newDict)
            {
                Console.WriteLine($"{item.Key} : { item.Value}");
            }
        }
    }
}
