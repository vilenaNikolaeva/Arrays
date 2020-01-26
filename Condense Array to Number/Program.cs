using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condence = new int[numbers.Length - 1];

            if (numbers.Length==1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < condence.Length-i; j++)
                {
                    condence[j]= numbers[j] + numbers[j + 1];
                }
                numbers = condence;
            }
            Console.WriteLine(condence[0]);
        }
    }
}
