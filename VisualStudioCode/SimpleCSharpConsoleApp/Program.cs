// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleCSharpApp {
    class Program {
        static int Main(string[] args) {
            // get args using System.Environment
            string[] theArgs = Environment.GetCommandLineArgs();
            Console.WriteLine("****** My First CSharp App *******");
            Console.WriteLine("Hello World!!");
            Console.WriteLine();

            // Process any incoming args
            foreach (string arg in theArgs) 
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            // Wait for enter key to be pressed before shutting down
            ShowEnvironmentDetails();
            Console.ReadLine();

            // Return an abitrary error code
            return -1;
            }

            static void ShowEnvironmentDetails()
            {
                // Print out the drives on this machine and other interesting details
                foreach (string drive in Environment.GetLogicalDrives())
                {
                    Console.WriteLine("Drive: {0}", drive);
                }
                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
                Console.WriteLine(".NET Core Version: {0}", Environment.Version);
            }
    }
}