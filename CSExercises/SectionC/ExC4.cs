using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {
            //Your code here
            Console.WriteLine("Enter travel distance in Kilometers");
            double distance = Convert.ToDouble(Console.ReadLine());         //Convert string distance to Double
            
            double fare = CalculateFare(distance);
            Console.WriteLine("Fare is ${0:0.00}", fare);
            Console.ReadLine();


        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double fare = 0;                                                //initialize double to 0
            double nextdistance = distance - 0.5;
            double lastdistance = distance - 0.5 - 8.5;
            double lastdistanceRoundup = Math.Ceiling(lastdistance * 10) / 10;  //Roundup lastdistance


            if (distance > 0.5 && distance <= 9)
            {
                fare = 2.40 + nextdistance * 10 * 0.04;
            }
            else if (distance > 9)
            {
                fare = 2.40 + 3.40 + lastdistanceRoundup * 10 * 0.05;
            }
            else
            {
                fare = 2.40;
            }

            return fare;



        }
    }
}