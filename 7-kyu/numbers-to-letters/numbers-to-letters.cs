using System;
using System.Text;
public class Kata
{
    public static string Switcher(string[] x)
    {
        StringBuilder result = new StringBuilder();
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
        char[] alphabet = { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };
        for(int i=0; i<x.Length; i++)
        {
            int num = int.Parse(x[i]);
            if (num <= 26)
            {
           result.Append(alphabet[num-1]);
            }
            else if(num == 27)
            {
                result.Append('!');
            }
            else if (num == 28)
            {
                result.Append('?');
            }
            else if (num == 29)
            {
                result.Append(' ');
            }
        }
        return result.ToString();
    }
}