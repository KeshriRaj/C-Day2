using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Utility
    {
        List<string> arrayOfString = new List<string>();
        List<string> palindromicString = new List<string>();


        public void GetPalindrome()
        {
            Console.WriteLine("Enter the size of String Array for finding Palindromic String");
            var numOfStrings = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numOfStrings; i++)
            {
                Console.WriteLine("Enter String" + (i + 1));
                this.arrayOfString.Add(Console.ReadLine());
            }

            foreach (string element in arrayOfString)
            {
                bool check = true;
                for (int i = 0; i < (element.Length / 2); i++)
                {
                    if (element[i] != element[element.Length - 1 - i])
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    this.palindromicString.Add(element);
                }
            }
            if (this.palindromicString.Count > 0)
            {
                Console.WriteLine("******************************** PALINDROMIC STRINGS IN ARRAY ARE :- *********************************");
                foreach (string element in this.palindromicString)
                {
                    Console.WriteLine(element);
                }

            }

        }
        public static void LastWord(string stringVariable, int position, char charToParse)
        {
            string[] words = stringVariable.Split(charToParse);
            if (position <= words.Length - 1)
                Console.WriteLine("Founded word at Position (" + position + ") is " + words[position]);
            else
                Console.WriteLine("No word found at " + position + " for string (" + stringVariable + ") after parsing in respect to character (" + charToParse + ")");
        }
    }
}
