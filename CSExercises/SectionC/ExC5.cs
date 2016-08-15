using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter a 3-digit number: ");
            string n = Console.ReadLine();

            bool IsArmstrongNumber;                                          //return IsArmstrongNumber true/false?

            Console.WriteLine("IsArmStrongNumber?\t{0}", IsArmstrongNumber); //how to call?
            Console.ReadLine();


        }


        public static bool IsArmstrongNumber(string n)
        {
            //YOUR CODE HERE

            string n1 = n.Substring(0, 1);
            string n2 = n.Substring(1, 1);
            string n3 = n.Substring(2, 1);

            int nInt = Convert.ToInt32(n);
            int n1Int = Convert.ToInt32(n1);
            int n2Int = Convert.ToInt32(n2);
            int n3Int = Convert.ToInt32(n3);

            int n1IntCube = n1Int * n1Int * n1Int;
            int n2IntCube = n2Int * n2Int * n2Int;
            int n3IntCube = n3Int * n3Int * n3Int;
            int sum = n1IntCube + n2IntCube + n3IntCube;

            bool IsArmstrongNumber;

            if (sum == nInt)
            {
                IsArmstrongNumber = true;
            }
            else
            {
                IsArmstrongNumber = false;
            }

            return IsArmstrongNumber;

        }
    }
}