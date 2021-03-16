using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(); // use preset Random class and set it in the rnd variable

            int winNum = rnd.Next(0, 100); // rnd.next selects a number betweem 0 and 100 and then sets the winning number as winNum

            bool win = false; // set the default win state as false when game launches

            do // carry out this code
            {

                Console.WriteLine("Guess a number between 0 and 100"); // set the games opening message
                string s = Console.ReadLine(); // get players input
                int i = int.Parse(s); // checks to see if player has entered a number or letter


                if (i > winNum) // if the entered number is higher than the winning number
                {

                    Console.WriteLine("Too high! Guess lower."); // displays message
                }

                else if (i < winNum) // if the entered number is lower than the winning number
                {

                    Console.WriteLine("Too low! Guess higher."); // displays message
                }

                else if (i == winNum) // if the entered number is the correct winning number
                {

                    Console.WriteLine(); // add blank line to space out guesses
                    Console.WriteLine("YOU WIN!!"); // display message
                    win = true; // change games win state to true
                }

                Console.WriteLine(); // add blank line to space out guesses
            }

            while (win == false); // while the game win state is false it will carry out the code

            Console.WriteLine("Thank you for playing the game!"); // display thank you message
            Console.Write("Press any key to close"); // asks player to enter a key
            Console.ReadKey(true); // takes any keypress as true
        }
    }
}
