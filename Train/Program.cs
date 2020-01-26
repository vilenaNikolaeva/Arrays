using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train=new int [wagons];

            for (int i = 0; i < wagons; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());
                train[i] = peopleInWagon;
            }
            int sum = train.Sum();
            Console.Write(string.Join(" ",train));
            Console.WriteLine(sum);
        }
    }
}
