namespace without_if_statements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<(Func<char, bool> predicate, Action action)> commandMap;
        
        private static void SetupCommandMap ()
        {
            commandMap = new List<(Func<char, bool> predicate, Action action)>();

            commandMap.Add(((choice) => choice == 'D' || choice == 'd', () => PrintResult("You voted for Dogs")));
            commandMap.Add(((choice) => choice == 'C' || choice == 'c', () => PrintResult("You voted for Cats")));
            commandMap.Add(((choice) => choice == 'R' || choice == 'r', () => PrintResult("You voted for Rabbits")));
            
            // a default action to take when no command is matched
            commandMap.Add(((choice) => true, () => {
                Console.WriteLine("Invalid selection, press return and select an option from the menu");
                Console.ReadLine();
                PrintMenu();
            }));
        }

        static void Main()
        {
            SetupCommandMap();
            PrintMenu();

            do
            {
                var choice = Console.ReadKey().KeyChar;
                commandMap.First(x => x.predicate(choice)).action();
            } while (true);
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("***********");
            Console.WriteLine("** With If Statements Demo **");
            Console.WriteLine("***********");
            Console.WriteLine();
            Console.WriteLine("Vote for your favourite pet");
            Console.WriteLine();

            Console.WriteLine("D - Dogs");
            Console.WriteLine("C - Cats");
            Console.WriteLine("R - Rabbits");
        }

        static void PrintResult(string msg)
        {
            Console.Clear();
            Console.WriteLine("******* Thanks for your vote *******");
            Console.WriteLine();
            Console.WriteLine(msg);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
