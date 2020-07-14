using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to parsed");
            string stringVariable = Console.ReadLine();
            Console.WriteLine("Enter Position");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the character to be parsed");
            char parse = Convert.ToChar(Console.ReadLine());

            Utility obj = new Utility();

            Utility.LastWord(stringVariable, position, parse);
            obj.GetPalindrome();

            Console.WriteLine("Enter Temperature in Celsius");
            double Celsius = Convert.ToDouble(Console.ReadLine());

            double Faranheit1 =Temperature.CelsiusToFarenheit(Celsius);

            Console.WriteLine(Celsius + "*C equal to " +Faranheit1 + "*F");

            Console.WriteLine("Enter Temperature in Farenheit");

            double Farenheit = Convert.ToDouble(Console.ReadLine());
            

            double Celsius1 =Temperature.FarenheitToCelsius(Farenheit);

            Console.WriteLine(Farenheit+"*F equal to "+Celsius1+"*C");
            
        }
    }
}
