using System;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split();

            for (int i= letters.Length-1; i >=0; i--)
            {
                string currentLetter = letters[i];
                Console.Write($"{currentLetter} ");
            }
        }
    }
}
