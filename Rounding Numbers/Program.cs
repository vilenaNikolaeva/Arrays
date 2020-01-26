using System;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] numbers=Console.ReadLine().Split();

            for (int i = 0; i < numbers.Length; i++)
            {
                string roundenNumber = numbers[i];
                double result =double.Parse(roundenNumber);
                Console.WriteLine($"{roundenNumber} => {Math.Round(result,MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
