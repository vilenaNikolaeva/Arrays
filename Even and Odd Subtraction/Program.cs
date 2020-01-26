using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int curretnNumber = numbers[i];

                if (curretnNumber%2==0)
                {
                    evenSum += curretnNumber;
                }
                else
                {
                    oddSum += curretnNumber;
                }
            }
            int result =(evenSum - oddSum);
            Console.WriteLine(result);
        }
    }
}
