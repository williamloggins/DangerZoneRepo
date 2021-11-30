using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word: ");
            Console.WriteLine(ReverseArray(Console.ReadLine()));
        }

        public static string ReverseArray(string s)
        {
            char[] coolArray = s.ToCharArray();
            Array.Reverse(coolArray);
            return new string(coolArray);
        }
    }
}

// ask the user to enter a string
// create a method that makes word a char array, then use the reverse function
// call that method, then return that back to main to display