using System;
using System.Linq;

namespace ZIg_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] firstArr =new int[rows];
            int[] secondArr = new int[rows];

            for (int i =0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                    if (i % 2 == 0)
                    {
                        firstArr[i] = numbers[0];
                        secondArr[i] = numbers[1];
                    }
                    else
                    {
                    firstArr[i] = numbers[1];
                    secondArr[i] = numbers[0];
                    }
            }
            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ",secondArr));
        }
    }
}
