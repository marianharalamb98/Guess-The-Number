using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(100);
            int userGuess = 0;

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your number:");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} is too high!", userGuess);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} is too small!", userGuess);
                }
                else
                {
                    Console.WriteLine("{0} is right!", userGuess);
                }

            }
        }
    }
}
