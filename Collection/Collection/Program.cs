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
        }
    }
}
