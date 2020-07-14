using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    static class Temperature
    {
        public static double CelsiusToFarenheit(double Celsius)
        {
            double farenheit =(9*Celsius)/5 + 32;
            return farenheit;
        }
        public static double FarenheitToCelsius(double Farenheit)
        {
            double Celsius = (Farenheit - 32)*5/9;
            return Celsius;
        }
    }
}
