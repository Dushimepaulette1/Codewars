using System;
using System.Linq;
​
​
public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
​
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        for(int i=0; i<str.Length; i++)
        {
            if(vowels.Contains(str[i]))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
}
​