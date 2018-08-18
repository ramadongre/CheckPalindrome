using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //these are the strings to be checked for being palindromes
            string[] strarr = { "ROTOR", "12345", "MOTOR", "MADAM" };


            for (int i = 0; i < strarr.Where(a => a.Length % 2 == 1).ToArray().Length; i++)//exclude those strings with even number of characters as they are not suitable to be palindromes.
            {
                string contextualStr = strarr[i];

                bool wasitPalindrome = true;
                for (int j = 0; j < (contextualStr.Length / 2); j++)
                {
                    if (contextualStr[j] != contextualStr[contextualStr.Length - 1 - j])
                    {
                        wasitPalindrome = false;
                        continue;
                    }
                }

                if (wasitPalindrome)
                    Console.WriteLine("The string '" + contextualStr + "' is a palindrome.");
            }

            Console.ReadKey();
        }
    }
}