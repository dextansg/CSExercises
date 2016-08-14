using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter a value for x");
            int x = Convert.ToInt32(Console.ReadLine());        //Convert String to Int32
            /* 
            int x1 = (5 * x * x);                               //Compute 5xx
            int x2 = (4 * x);                                   //Compute 4x
            int y = (x1 - x2 + 3);                              //Compute y=5xx-4x+3 
            */
            int y = (5 * x * x - 4 * x + 3);
            Console.WriteLine(y);                               //Print Answer
            Console.ReadLine();
        }

        public static double CalculateY(double x)
        {
            //YOUR CODE HERE
            return 0;
        }
    }
}
