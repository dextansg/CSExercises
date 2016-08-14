using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            /*
            string inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);

            int result = square(inputInt);

            Console.WriteLine(result);
            */
            
            Console.WriteLine("Input an Integer"); //Ask for input
            string strNumber = Console.ReadLine(); //Input as String
            int i = Convert.ToInt32(strNumber);    //Convert String to Int
            int Result = i * i;                    //takes Square of Int i or Math.Pow(i,2);
            Console.WriteLine(Result);             //Print Result
            Console.ReadLine();
        }

        public static int square(int x)
        {
            //PUT YOUR CODE HERE
            return 0;

        }
    }
}
