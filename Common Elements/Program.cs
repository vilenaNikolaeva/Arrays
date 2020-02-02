using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(" ").ToArray();
            var secondArr = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int k = 0; k < firstArr.Length; k++)
                {
                    if (firstArr[k]==secondArr[i])
                    {
                        Console.Write(secondArr[i]+ " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
