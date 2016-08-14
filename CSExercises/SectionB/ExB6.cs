using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter x1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Distance is {0}", Distance);
            Console.ReadLine();
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            return 0;
        }
    }
}
