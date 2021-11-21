using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartingPosition = 0;
            int Ladder = 1;
            int Snake = 2;
            int CurrentPosition = 0;
            const int WinnigPosition = 100;

            while (CurrentPosition <= WinnigPosition)
            {
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
                    if (CurrentPosition < StartingPosition)
                    {
                        CurrentPosition = StartingPosition;
                        Console.WriteLine("Snake Current Position " + CurrentPosition);
                    }
                    else
                    {
                        Console.WriteLine("Snake Current Position " + CurrentPosition);
                    }
                }
                else
                {
                    Console.WriteLine("Their is no play");
                }
            }
        }
    }
}