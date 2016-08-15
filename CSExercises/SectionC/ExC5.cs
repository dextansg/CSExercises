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
            string s = Console.ReadLine();

            string n1 = s.Substring(0, 1);
            string n2 = s.Substring(1, 1);
            string n3 = s.Substring(2, 1);

            int n = Convert.ToInt32(s);
            int n1Int = Convert.ToInt32(n1);
            int n2Int = Convert.ToInt32(n2);
            int n3Int = Convert.ToInt32(n3);

            int n1IntCube = n1Int * n1Int * n1Int;
            int n2IntCube = n2Int * n2Int * n2Int;
            int n3IntCube = n3Int * n3Int * n3Int;
            int sum = n1IntCube + n2IntCube + n3IntCube;

            bool IsArmstrongNo;

            if (sum == n)
            {
                IsArmstrongNo = true;
            }
            else
            {
                IsArmstrongNo = false;
            }


            Console.WriteLine("IsArmStrongNo?\t{0}",IsArmstrongNo);
            Console.ReadLine();


        }


        /*public static bool IsArmstrongNumber(int x)
        {
            //YOUR CODE HERE
            int sum = 0;

            if (sum == n)
            {
               bool IsArmstrongNumber = true;
            }
            else
            {
                bool IsArmstrongNumber = false;
            }
            return;

        }*/
    }
}