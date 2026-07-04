using System.Collections;
using System.Collections.Generic;
​
public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     List<int> numbersList = new List<int>();
    for (int i=0; i<listOfItems.Count; i++)
        {
            if(listOfItems[i] is int num)
            {
                numbersList.Add(num);
            }
        }
     return numbersList;
   }
}
​