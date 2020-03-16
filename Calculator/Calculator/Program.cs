using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // RECEIVE USER INPUT AND
            // FORMAT INPUT INTO USABLE DATA TYPES
            Console.WriteLine("Welcome to my Magical Code Calculator! I can do arithmetic for you.");

            // parameter a
            Console.WriteLine("Enter a number or decimal:");
            double doubleA = RequestNum(Console.ReadLine());

            // operator
            Console.WriteLine("Enter your operator: \n(+, -, *, or /)");
            string inputO = RequestOp(Console.ReadLine());

            // parameter b
            Console.WriteLine("Enter a second number or decimal:");
            double doubleB = RequestNum(Console.ReadLine());

            // PRINT OUTPUT
            // calculate
            double outcome = 0;
            switch(inputO)
            {
                case "+":
                    outcome = Add(doubleA, doubleB);
                    break;
                case "-":
                    outcome = Subtract(doubleA, doubleB);
                    break;
                case "*":
                    outcome = Multiply(doubleA, doubleB);
                    break;
                case "/":
                    outcome = Divide(doubleA, doubleB);
                    break;
            }

            // print
            Console.WriteLine($"The answer is {outcome}!");

        }

        static double RequestNum(string input)
        {
            double result;
            while (!Double.TryParse(input, out result))
            {
                Console.WriteLine("I didn't understand that, try again:");
                input = Console.ReadLine();
            }
            return result;
        }

        static string RequestOp(string opera)
        {
            while (opera != "+" && opera != "*" && opera != "-" && opera != "/")
            {
                Console.WriteLine("That wasn't an arithmetic operator, try again: \n(+, -, *, or /)");
                opera = Console.ReadLine();
            }
            return opera;
        }

        static double Add(double a, double b)
        {
            double c = a + b;
            return c;
        }
        static double Subtract(double a, double b)
        {
            double c = a - b;
            return c;
        }
        static double Multiply(double a, double b)
        {
            double c = a * b;
            return c;
        }
        static double Divide(double a, double b)
        {
            // Test for "Divide by 0 errors"
            if (b == 0 || a == 0) { 
                Console.WriteLine("I cannot divide with a 0, try again:");
                string inputA = a.ToString();
                string inputB = b.ToString();

                while (!Double.TryParse(inputA, out a) || a == 0)
                {
                    Console.WriteLine("Reset your first number, please:");
                    inputA = Console.ReadLine();
                }
                while (!Double.TryParse(inputB, out b) || b == 0)
                {
                    Console.WriteLine("Reset your second number, please:");
                    inputB = Console.ReadLine();
                }
            }

            double c = a / b;
            return c;
        }

    }
}
