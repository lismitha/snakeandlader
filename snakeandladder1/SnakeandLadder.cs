using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //int StartingPosition = 0;
            //Console.WriteLine("Starting position " + StartingPosition);

            int Ladder = 1;
            int Snake = 2;
            int CurrentPosition = 0;

            Random random = new Random();
            int DiceNumber = random.Next(1, 7);

            Random rand = new Random();
            int Option = rand.Next(0, 3);

            Console.WriteLine("Dice Number is " + DiceNumber);

            if (Option == Ladder)
            {
                CurrentPosition = CurrentPosition + DiceNumber;
                Console.WriteLine("Ladder Current Position " + CurrentPosition);
            }
            else if (Option == Snake)
            {
                CurrentPosition = CurrentPosition - DiceNumber;
                Console.WriteLine("Snake Current Position " + CurrentPosition);
            }
            else
            {
                Console.WriteLine("Their is no play");
            }
        }
    }
}