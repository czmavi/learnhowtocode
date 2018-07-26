using System;

namespace Algebra
{
   public class Program
    {
        public static void Main(string[] args)
        {
            //HelloWorld();
            //Readline();
            //Addition();
            //Substraction();
            AdditionAndSubstraction();
            Console.ReadLine();
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static void Readline()
        {
            var providedValue = Console.ReadLine();
            Console.WriteLine("Input: " + providedValue);
        }

        public static void Addition()
        {
            Console.WriteLine("X:");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            var y = Int32.Parse(Console.ReadLine());
            var total = x + y;
            Console.WriteLine(x + " + " + y + " = " + total);
        }

        public static void Substraction()
        {
            Console.WriteLine("X:");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            var y = Int32.Parse(Console.ReadLine());
            var total = x - y;
            Console.WriteLine(x + " - " + y + " = " + total);
        }

        public static void AdditionAndSubstraction()
        {
            Console.WriteLine("X:");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Z:");
            var z = Int32.Parse(Console.ReadLine());
            var total = x + y - z;
            Console.WriteLine(x + " + " + y + " - " + z + " = " + total);
        }
    }
}
