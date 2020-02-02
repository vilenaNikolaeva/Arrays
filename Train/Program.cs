using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
           var lines =int.Parse(Console.ReadLine());
            var sum = 0;
            int[] arr = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine(sum);
        }
    }
}
