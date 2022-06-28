using System;
using System.Collections.Generic;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Random rnd = new Random();
            int rndIndex = rnd.Next(0, numbers.Count - 1);
            int numberToGuess = numbers[rndIndex];

            int guessNumber = int.Parse(Console.ReadLine());

            while (guessNumber != numberToGuess)
            {
                if (guessNumber > numbers[numbers.Count - 1] || guessNumber < numbers[0])
                {
                    Console.WriteLine("Invalid number");
                    guessNumber = int.Parse(Console.ReadLine());
                    continue;
                }

                int index = numbers.IndexOf(guessNumber);

                if (guessNumber < numberToGuess)
                {
                    Console.WriteLine("Bigger -->");
                    numbers.RemoveRange(0, index + 1);
                }
                else
                {
                    Console.WriteLine("Smaller <--");
                    numbers.RemoveRange(index, numbers.Count - index);
                }

                guessNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Correct! Num: {guessNumber}");
        }
    }
}
