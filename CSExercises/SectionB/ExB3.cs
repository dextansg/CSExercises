using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter your Salary");
            double Salary = Convert.ToDouble(Console.ReadLine());        //Convert String to Double
            double Housing = (0.1 * Salary);                             //Compute Housing Allowance 10%
            double Transport = (0.03 * Salary);                          //Compute Transport Allowance 3%
            double TotalSalary = (Salary + Housing + Transport);         //Compute Total Salary Add All
            Console.WriteLine("Total Salary is ${0:0.00}", TotalSalary); //Print Total Salary in $##.## format
            Console.ReadLine();

        }

        public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            return null;
        }
    }
}
