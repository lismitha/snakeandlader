using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int DiceNumber = random.Next(1, 7);

            Console.WriteLine("Dice Number is " + DiceNumber);

        }
    }
}