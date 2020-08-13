using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class CollectionsFunctions
    {
        public List<string> ListOperations(List<string> stringsList)
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
            return stringsList;
            
        }
    }
}
