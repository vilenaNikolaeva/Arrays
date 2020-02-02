using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxCount = 1;
            int currentCount = 1;
            int number = num[0];

            for (int i = 0; i < num.Length - 1; i++)
            {
                int secondElement = num[i + 1];
                int currentElement = num[i];
                if (currentElement == secondElement)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        number = currentElement;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
