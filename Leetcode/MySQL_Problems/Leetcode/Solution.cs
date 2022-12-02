using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class Solution
    {
        /*public static void IntToRoman()
        {
            var num = int.Parse(Console.ReadLine());//
            string romanResult = string.Empty;
            string[] romanLetters = {
            "M", "CM", "D", "CD", "C", "XC", "L",
            "XL", "X", "IX", "V", "IV", "I" };
           
            int[] numbers = {
            1000, 900, 500, 400, 100, 
            90, 50, 40, 10, 9, 5, 4, 1 };
            ////-- it can convert any number to Roman number
            int i = 0;
            while (num != 0)
            {
                if (num >= numbers[i]){
                    num -= numbers[i];
                    romanResult += romanLetters[i];
                }
                else{
                    i++;
                }
            }
            Console.WriteLine(romanResult);
        }*/
        //---------------------

        public static void RomanToInt()
        {
            var s = Console.ReadLine();
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for(int i=0; i < s.Count; i++)
            {

            }
        }
    }
}
