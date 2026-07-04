using System;
using System.Linq;
using System.Collections.Generic;
​
namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a)
    {
        List<int> final = new List<int>();
        for(int i=0; i<a.Length; i++)
        {
            if(!final.Contains(a[i]))
            {
                final.Add(a[i]);
            }
        }
      return final.ToArray();
    }
  }
}