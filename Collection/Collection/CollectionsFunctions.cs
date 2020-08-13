using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class CollectionsFunctions
    {
        public void ListOperations(ref List<string> stringsList)
        {
            int middleIndex;
            if(stringsList.Count % 2!= 0)
            {
                middleIndex = stringsList.Count / 2;
                stringsList.RemoveAt(middleIndex);
            }
            if(stringsList.Contains("mamas"))
            {
                stringsList.Add("6");
            }

            if(stringsList.Contains("aram"))
            {
                int index = stringsList.IndexOf("aram");
                if(index % 2 != 0)
                {
                    stringsList.Reverse();
                }
            }
            List<string> str = new List<string>{ "2", "3", "4" };
            var countOfDiffernetValues = stringsList.GroupBy(str => str).Count();
            if(countOfDiffernetValues == 3)
            {
                stringsList.InsertRange(2, str);
            }
        }

        public void DictionaryOperations(ref Dictionary<string, int> dictionary)
        {
            var keys = dictionary.Keys.ToList();
            if(keys.Contains("scuba"))
            {
                if(dictionary["scuba"] == 6)
                {
                    dictionary["Empire"] = 6;
                }
            }
        }

        public void StackOperations(ref Stack<DateTime> stack)
        {
            if(stack.Count > 0)
            {
                var head = stack.Peek();
                if (head < DateTime.Now)
                {
                    stack.Pop();
                    stack.Push(DateTime.Now);
                }
            }
        }
    }
}
