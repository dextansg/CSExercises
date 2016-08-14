using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Input a number");                //Ask for input number as String
            double i = Convert.ToDouble(Console.ReadLine());    //Convert String to Double
            double Result = Math.Sqrt(i);                       //Compute SquareRoot of Double
            Console.WriteLine("{0:0.###}", Result);             //Prints Result to 3 dec. places if any
            Console.ReadLine();
        }

        public static string SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x and then use String.Format 
            //to format it. The format is similar to WriteLine
            return null;

        }
    }
}
