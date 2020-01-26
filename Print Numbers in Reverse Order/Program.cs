using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
