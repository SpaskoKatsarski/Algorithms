using System;
using System.Linq;

namespace MergeAlgurithmExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int indexOne = 0;
            int indexTwo = 0;
            int resultIndex = 0;

            int[] result = new int[arrOne.Length + arrTwo.Length];

            while (indexOne < arrOne.Length && indexTwo < arrTwo.Length)
            {
                if (arrOne[indexOne] <= arrTwo[indexTwo])
                {
                    result[resultIndex] = arrOne[indexOne];
                    resultIndex++;
                    indexOne++;
                }
                else
                {
                    result[resultIndex] = arrTwo[indexTwo];
                    resultIndex++;
                    indexTwo++;
                }
            }

            for (int i = indexOne; i < arrOne.Length; i++)
            {
                result[resultIndex] = arrOne[i];
                resultIndex++;
            }

            for (int i = indexTwo; i < arrTwo.Length; i++)
            {
                result[resultIndex] = arrTwo[i];
                resultIndex++;
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
