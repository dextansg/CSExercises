using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter distance travelled in Kilometres");
            double Distance = Convert.ToDouble(Console.ReadLine());
            double Fare = (2.40 + Distance * 0.4);                 //how to round to nearest 10 cents
            double EstFare = Math.Round(Fare, 1);                  //Round to 1 dec. place = 10 cents
            Console.WriteLine("Fare is ${0:0.00}", EstFare);
            Console.ReadLine();
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            return 0;

        }
    }
}
