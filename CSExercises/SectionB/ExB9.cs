using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter distance travelled in Kilometres");
            double Distance = Convert.ToDouble(Console.ReadLine());
            double Fare = (2.40 + Distance * 0.4);                 //how to round UPWARDS to nearest 10 cents
            double EstFare = Math.Ceiling(Fare * 10)/10;           //RoundUP to 1 dec. place = 10 cents
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
