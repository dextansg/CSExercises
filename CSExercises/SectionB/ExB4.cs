using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter Temperate in Celsius");
            double C = Convert.ToInt32(Console.ReadLine());                 //Convert Celsius String to Int32
            double F = (1.8 * C + 32);                                      //Compute Temp in Fahrenheit
            Console.WriteLine("Temperature in Fahrenheit is {0:0}", F);     //Print Temp in Fahrenheit
            Console.ReadLine();

        }

        public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            return 0;

        }
    }
}
