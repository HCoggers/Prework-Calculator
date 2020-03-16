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
            string inputA = Console.ReadLine();
            double doubleA;
            while (!Double.TryParse(inputA, out doubleA))
            {
                Console.WriteLine("I didn't understand that, try again:");
                inputA = Console.ReadLine();
            }

            // operator
            Console.WriteLine("Enter your operator: \n(+, -, *, or /)");
            string inputO = Console.ReadLine();
            while (inputO != "+" && inputO != "*" && inputO != "-" && inputO != "/")
            {
                Console.WriteLine("That wasn't an arithmetic operator, try again: \n(+, -, *, or /)");
                inputO = Console.ReadLine();
            }

            // parameter b
            Console.WriteLine("Enter a second number:");
            string inputB = Console.ReadLine();
            double doubleB;
            while (!Double.TryParse(inputB, out doubleB) || ((doubleB == 0 || doubleA == 0) && inputO == "/"))
            {
                if (Double.TryParse(inputB, out doubleB) && (doubleB == 0 || doubleA == 0) && inputO == "/")
                {
                    Console.WriteLine("I cannot divide with a 0, try again:");
                    while (!Double.TryParse(inputA, out doubleA) || doubleA == 0)
                    {
                        Console.WriteLine("Reset your first number, please:");
                        inputA = Console.ReadLine();
                    }
                    if (doubleB == 0)
                        inputB = Console.ReadLine();
                } else
                {
                    Console.WriteLine("I didn't understand that, try again:");
                    inputB = Console.ReadLine();
                }
            }

            // PRINT OUTPUT
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

            Console.WriteLine($"The answer is {outcome}!");

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
            double c = a / b;
            return c;
        }

    }
}
