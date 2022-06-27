using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        double[] coins = new double[] { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00, 1.00, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
        Queue<double> resultCoins = new Queue<double>();

        Console.WriteLine("Note input: ");
        double finalSum = double.Parse(Console.ReadLine());
        double currentSum = 0;

        for (int i = 0; i < coins.Length; i++)
        {
            if (currentSum + coins[i] > finalSum)
            {
                continue;
            }

            currentSum += coins[i];
            resultCoins.Enqueue(coins[i]);
            i--;
        }

        Console.WriteLine($"Used coins: ");
        foreach (var coin in resultCoins)
        {
            Console.Write($"{coin:f2}$, ");
        }
    }
}
