using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{

    //Write a program that will print out your detail in the following format:
    //Line 1: Name
    //Line 2: Email

    //Example:
    //John Smith
    //e0011223 @u.nus.edu

    public class ExA1
    {
        public static void Main(string[] args)
        {
            /* can combine these two into ONE line
            Console.WriteLine("John Smith");
            Console.WriteLine("e0011223 @u.nus.edu"); */
            Console.WriteLine("John Smith\ne0011223@u.nus.edu");
        }
    }
}
