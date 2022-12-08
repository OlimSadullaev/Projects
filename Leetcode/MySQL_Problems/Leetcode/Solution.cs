using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class Solution
    {
        public static void IntToRoman1() //////11111111
        {
            var num = int.Parse(Console.ReadLine());//
            //var n = double.Parse(Console.ReadLine());
            if (num <= 0) Console.WriteLine("");
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] n = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            StringBuilder sb = new();
            for(int i=0; num!=0; i++)
            {
                while(num >= n[i])
                {
                    num -= n[i];
                    sb.Append(roman[i]);
                }
            }
            Console.WriteLine(sb.ToString());

        }
        ////-----------------------------
        //Roman to int
        public static void RomanToInt2() ////////2222222
        {
            string s = Console.ReadLine();

            var dictionary = new Dictionary<char, int>();

            dictionary.Add('I', 1);
            dictionary.Add('V', 5);
            dictionary.Add('X', 10);
            dictionary.Add('L', 50);
            dictionary.Add('C', 100);
            dictionary.Add('D', 500);
            dictionary.Add('M', 1000);

            int solution = 0;

            s = s.Replace("IV", "IIII")
            .Replace("IX", "VIIII")
            .Replace("XL", "XXXX")
            .Replace("XC", "LXXXX")
            .Replace("CD", "CCCC")
            .Replace("CM", "DCCCC");

            foreach (char c in s)
            {
                solution += dictionary[c];
            }

            Console.WriteLine(solution);
        }
    }
}
