## Old Method of Declaring Main

// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleCSharpApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("****** My First CSharp App *******");
            Console.WriteLine("Hello World!!");
            Console.WriteLine();

            // Wait for enter key to be pressed before shutting down
            Console.ReadLine();
        }
    }
}