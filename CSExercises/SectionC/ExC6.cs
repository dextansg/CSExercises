using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.Write("How many TV will you like to buy: ");
            int tvQty = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many DVD will you like to buy: ");
            int dvdQty = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many mp3 will you like to buy: ");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());

            double totalPrice = CalculateTotalPrice (tvQty, dvdQty, mp3Qty);

            Console.WriteLine("Total Price after discount is ${0:0.00}", totalPrice);
            Console.ReadLine();

        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double tvPrice = tvQty * 900;
            double dvdPrice = dvdQty * 500;
            double mp3Price = mp3Qty * 700;
            double subTotal = tvPrice + dvdPrice + mp3Price;
            double totalPrice = 0;

            if (subTotal > 5000 && subTotal <= 10000)
            {
                totalPrice = tvPrice * 0.9 + dvdPrice * 0.9 + mp3Price;
            }
            else if (subTotal > 10000)
            {
                totalPrice = tvPrice * 0.85 + dvdPrice * 0.85 + mp3Price;
            }
            else
            {
                totalPrice = subTotal;
            }

            return totalPrice;

        }
    }
}