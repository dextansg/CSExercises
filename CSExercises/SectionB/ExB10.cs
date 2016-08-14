using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter lengths of 3 sides of a triangle");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double Perimeter = (A + B + C);
            double s = (Perimeter / 2);
            double a = (s - A);
            double b = (s - B);
            double c = (s - C);
            double Area = Math.Sqrt(s * a * b * c);
            Console.WriteLine("Area is {0}", Area);
            Console.ReadLine();
        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            return 0;
        }
    }
}
