using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(" ");
            string[] secondArr = Console.ReadLine().Split(" ");

            string commonElements = string.Empty;

            for (int i = 0; i < secondArr.Length; i++)
            {
                string currentSecondElement = secondArr[i];
                for (int j = 0; j < firstArr.Length; j++)
                {
                    string currentFirstElement = firstArr[j];
                    if (currentFirstElement == currentSecondElement)
                    {
                        Console.Write
                            ($"{currentSecondElement+ " "}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
