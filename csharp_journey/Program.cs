// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test
{
    class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine(GetDay(4));

                int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);


            //GUESSING GAME
            Console.WriteLine("Welcome to raheem's guessing game");
            string secretWord = "encrypted";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            
            while (guess != secretWord)
            {

                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess word : ");
                    guess = Console.ReadLine();
                    guessCount++;
                    if (guess != secretWord)
                    {
                        Console.WriteLine("wrong guess try again");
                    }
                }
                else
                {
                    outOfGuesses = true;
                    Console.WriteLine("out of guesses");
                }
                


            }

            Console.WriteLine("Yes!!, your guess was right");


            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "invalid day number ";
                    break;
            }
            return dayName;
        }

    }
    
}
