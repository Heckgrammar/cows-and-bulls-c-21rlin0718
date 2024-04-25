using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cows and Bulls Starter Framework Code

            //start of game
            int cows = 0;
            int bulls = 0;
            int guesses = 0;
            string playAgain = "Yes";
            while (playAgain == "Yes" || playAgain == "yes") 
            {
                bool valid = false;
                int intNum = 0;
                string num = "0";
                int value1 = 0;
                int value2 = 0;
                int value3 = 0;
                int value4 = 0;

                //resets bulls to 0 if user decides to play again
                bulls = 0;

                //resets guesses to 0 if user decides to play again
                guesses = 0;

                while (bulls != 4)
                {
                    //gets random number: 4 digits, no repeating digits, doesn't start with 0
                    while (valid == false)
                    {
                        Random random = new Random();
                        intNum = random.Next(1023, 9877);
                        num = intNum.ToString();
                        value1 = num[0];
                        value2 = num[1];
                        value3 = num[2];
                        value4 = num[3];
                        if (value1 == value2 || value1 == value3 || value1 == value4 || value2 == value3 || value2 == value4 || value3 == value4)
                        {
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    string userNum = " ";
                    int userValue1 = 0;
                    int userValue2 = 0;
                    int userValue3 = 0;
                    int userValue4 = 0;

                    cows = 0;
                    bulls = 0;
                    valid = false;

                    while (valid == false)
                    {
                        //getting a valid number from user
                        Console.WriteLine("Enter 4 digit number: no repeats, doesn't begin with 0");
                        userNum = Console.ReadLine();
                        int length = userNum.Length;
                        if (length != 4)
                        {
                            valid = false;
                        }
                        else
                        {

                            userValue1 = userNum[0];
                            userValue2 = userNum[1];
                            userValue3 = userNum[2];
                            userValue4 = userNum[3];
                            if (userValue1 == userValue2 || userValue1 == userValue3 || userValue1 == userValue4 || userValue2 == userValue3 || userValue2 == userValue4 || userValue3 == userValue4)
                            {
                                valid = false;
                            }
                            else if (userValue1 == '0')
                            {
                                valid = false;
                            }
                            else
                            {
                                valid = true;
                            }
                        }
                        if (valid == false)
                        {
                            Console.WriteLine("Invalid number. Please try again.");
                        }
                    }

                    //records how many guesses the user took to get the right number
                    guesses = guesses + 1;

                    //calculating the number of cows
                    if (userValue1 == value2)
                    {
                        cows = cows + 1;
                    }
                    if (userValue1 == value3)
                    {
                        cows = cows + 1;
                    }
                    if (userValue1 == value4)
                    {
                        cows = cows + 1;
                    }
                    if (userValue2 == value1)
                    {
                        cows = cows + 1;
                    }
                    if (userValue2 == value3)
                    {
                        cows = cows + 1;
                    }
                    if (userValue2 == value4)
                    {
                        cows = cows + 1;
                    }
                    if (userValue3 == value1)
                    {
                        cows = cows + 1;
                    }
                    if (userValue3 == value2)
                    {
                        cows = cows + 1;
                    }
                    if (userValue3 == value4)
                    {
                        cows = cows + 1;
                    }
                    if (userValue4 == value1)
                    {
                        cows = cows + 1;
                    }
                    if (userValue4 == value2)
                    {
                        cows = cows + 1;
                    }
                    if (userValue4 == value3)
                    {
                        cows = cows + 1;
                    }

                    //getting number of bulls
                    if (userValue1 == value1)
                    {
                        bulls = bulls + 1;
                    }
                    if (userValue2 == value2)
                    {
                        bulls = bulls + 1;
                    }
                    if (userValue3 == value3)
                    {
                        bulls = bulls + 1;
                    }
                    if (userValue4 == value4)
                    {
                        bulls = bulls + 1;
                    }

                    Console.WriteLine("Cows: " + cows);
                    Console.WriteLine("Bulls: " + bulls);
                }
                Console.WriteLine("Congrats! You guessed the number " + num + " in " + guesses + " guesses.");

                Console.WriteLine("Play again?");
                playAgain = Console.ReadLine();

            }

            Console.WriteLine("End of game."); //outputs 'End of game' if user doesn't want to play again
            
        }
    }
}
