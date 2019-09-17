using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int Rand = rand.Next(0, 100);

            int input;
            int guesses = 0;

            Console.WriteLine("Guess my number!");
            input =  Convert.ToInt32(Console.ReadLine());

            while (input != Rand) {

                if (input < Rand)
                {
                    Console.WriteLine("Guess too low");
                    guesses++;
                    Console.WriteLine("Guess again");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                else if (input > Rand)
                {
                    Console.WriteLine("Guess too high");
                    guesses++;
                    Console.WriteLine("Guess again");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                

            }
            guesses++;
            Console.WriteLine($"Thats right you got it in {guesses} tries!!");
            Console.ReadKey();
        }
    }
}
