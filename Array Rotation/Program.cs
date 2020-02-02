using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrey = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numRotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRotation; i++)
            {
                int firstNum = arrey[0];
                for (int j = 0; j < arrey.Length-1; j++)
                {
                    arrey[j] = arrey[j + 1];
                }
                arrey[arrey.Length - 1] = firstNum;

            }
            Console.WriteLine(string.Join(" ",arrey));
        }
    }
}
