using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write "Write something"
            Console.WriteLine("Write something");

            // Read user input followed by enter
            var input = Console.ReadLine();

            // Write "Write something else"
            Console.WriteLine("Write something else");

            // Read second user input
            var input2 = Console.ReadLine();

            // Write what user has entered
            Console.WriteLine("First input: '" + input + "', Second input: '" + input2 + "'");

            // Write "Press enter to close"
            Console.WriteLine("Press enter to close");
            // Wait for enter is pressed so that console doesn´t close immediately
            Console.ReadLine();
        }
    }
}
