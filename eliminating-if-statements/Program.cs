namespace eliminating_if_statements
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();

            var choice = Console.ReadKey();
            
            if (choice.KeyChar == 'D' || choice.KeyChar == 'd')
            {
                PrintResult("You voted for Dogs");
            }
            else if (choice.KeyChar == 'C' || choice.KeyChar == 'c')
            {
                PrintResult("You voted for Cats");
            }
            else if (choice.KeyChar == 'R' || choice.KeyChar == 'r')
            {
                PrintResult("You voted for Rabbits");
            }
        }

        static void PrintMenu()
        {
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
