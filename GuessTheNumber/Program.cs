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
            var numberOfGuess = 1;
            Random random = new Random();
            var randomNumber = random.Next(0, 100);
            Console.WriteLine("Guess the random number from range 0-100");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("Choose number from range 0-100: ");
                    continue;
                }
                if (userInput == randomNumber)
                {
                    Console.WriteLine($"Congratulations you made it in {numberOfGuess} try.");
                    Console.ReadLine();
                    break;
                }
                else if (userInput > randomNumber)
                {
                    Console.WriteLine("Your number is too high.");
                    numberOfGuess ++;
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine("Your number is too low.");
                    numberOfGuess ++;
                }




            }
            
        }


    }
}
