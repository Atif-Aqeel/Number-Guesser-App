using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Change Forground Color
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Number Guesser: Version 1.0.0 by Atif Aqeel");

            //Change Forground Color
            Console.ForegroundColor = ConsoleColor.Green;

            //User Input
            Console.WriteLine("Please Enter Your Name :");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", name);

            //Reset text Color
            Console.ResetColor();

            //Set A Number
            int correctNumber = 18;

            // Guess a Number Var
            int guess = 0;

            Console.WriteLine("Guess a Number from 1 to Infinite");

            // While guess is not equal to correct number
            while(guess != correctNumber)
            {
                //Get User Input
                string num = Console.ReadLine();

                // Make sure its a number Not A Alphabets
                if (!int.TryParse(num, out guess) )
                {
                    //Change text Color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell User its not alphabet
                    Console.WriteLine("Please Enter an Actual Number");

                    //Reset text Color
                    Console.ResetColor();

                    //Keep Going
                    continue;

                }

                //Cast to int and put in guess
                guess = Int32.Parse(num);

                //Match guess to correct number
                if (guess != correctNumber)
                {
                    //Change Forground Color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Output
                    Console.WriteLine("Wromg Number, Please try again");

                    //Reset text Color
                    Console.ResetColor ();

                }

            }
            //Output success Message

            //Change Forground Color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Output
            Console.WriteLine("You Are Correct!!! ");

            //Reset text Color
            Console.ResetColor();

        }
    }
}
