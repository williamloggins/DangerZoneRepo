using System;

namespace FavoriteNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many favorite numbers do you have?");
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[nums];

            Console.WriteLine("\nNow, please enter your favorite numbers, each followed by pressing Enter 😊");

            for (int i = 0; i < nums; i++)
            {
                s[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(s);

            Console.WriteLine("\nHere are your favorite numbers in ascending order! You're welcome.");

            foreach (int a in s)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
