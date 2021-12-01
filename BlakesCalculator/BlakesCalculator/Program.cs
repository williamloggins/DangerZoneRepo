using System;

namespace BlakesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            IntroScene();
            GetNumbers(ref num1, ref num2);
            AskOperation(ref num1, ref num2);
            ExitScene();
            Console.ReadLine();
        }

        public static void IntroScene()
        {
            Console.WriteLine("Welcome to Blake's definitely unique Calculator App!");
        }

        public static void GetNumbers(ref double num1, ref double num2)
        {
            Console.Write("\nPlease enter a number: ");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter a second number: ");

            num2 = Convert.ToDouble(Console.ReadLine());
        }

        public static void AskOperation(ref double num1, ref double num2)
        {
            Console.WriteLine("\nWhat kind of operation would you like to do?\n");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.Write("\nOperation choice: ");
            string response = Console.ReadLine().ToUpper();
            double answer;

            switch (response)
            {
                case "A":
                    answer = Operations.Addition(num1, num2);
                    Console.WriteLine($"\nYour result: {num1} + {num2} = {answer}");
                    break;

                case "S":
                    answer = Operations.Subtraction(num1, num2);
                    Console.WriteLine($"\nYour result: {num1} - {num2} = {answer}");
                    break;

                case "M":
                    answer = Operations.Multiplication(num1, num2);
                    Console.WriteLine($"\nYour result: {num1} x {num2} = {answer}");
                    break;

                case "D":
                    answer = Operations.Division(num1, num2);
                    Console.WriteLine($"\nYour result: {num1} / {num2} = {answer}");
                    break;

                default:
                    Console.WriteLine("\nHey! That's not one of the choices.");
                    break;
            }
        }

        public static void ExitScene()
        {
            Console.WriteLine("\nThanks so much for using Blake's definitely unique Calculator App! 😊");
        }
    }
}
