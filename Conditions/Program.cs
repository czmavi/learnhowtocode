using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            IfTextLength();
            //IfTextLength();
            //IfTextLengthIsOverThree();
            //CalculatorUsingSwitch();

            Console.ReadLine();
        }

        public static void IfTextLength()
        {
            Console.WriteLine("Please write something");
            var text = Console.ReadLine();

            if (text.Length > 3)
            {
                Console.WriteLine("Input text length is greater than 3");
            }
            else
            {
                Console.WriteLine("Input text length is less or equal to 3");
            }
        }

        public static void IfTextEquals()
        {
            Console.WriteLine("Please write something");
            var text = Console.ReadLine();
            Console.WriteLine("Please write something again");
            var text2 = Console.ReadLine();

            if (text.Equals(text2))
            {
                Console.WriteLine("First text equals second text");
            }
            else
            {
                Console.WriteLine("First text doesn't equal second text");
            }
        }

        public static void IfTextLengthIsOverThree()
        {
            Console.WriteLine("Please write something");
            var text = Console.ReadLine();

            if (text.Length > 3)
            {
                Console.WriteLine("Text length is higher than three");
            }
            else
            {
                Console.WriteLine("Text length is three or lower");
            }
        }

        public static void CalculatorUsingSwitch()
        {
            Console.WriteLine("Please write first number");
            var a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please write operation type");
            var sign = Console.ReadLine();
            Console.WriteLine("Please write second number");
            var b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Result:");
            switch (sign)
            {
                case "+": Console.WriteLine(a + b); break;
                case "-": Console.WriteLine(a - b); break;
                case "*": Console.WriteLine(a * b); break;
                case "/": Console.WriteLine(a / b); break;
            }
        }
    }
}
