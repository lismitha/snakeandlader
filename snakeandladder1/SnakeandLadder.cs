using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //int StartingPosition = 0;
            //Console.WriteLine("Starting position " + StartingPosition);

            Random random = new Random();
            int DiceNum = random.Next(1, 7);

            Console.WriteLine("Dice Number is " + DiceNum);

        }
    }
}
