namespace eliminating_if_statements
{
    using System;

    class Program
    {
        static void Main()
        {
            // infinite loop to keep the app going until a valid choice is made
            do
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
                else
                {
                    // invalid option so try again
                    Console.WriteLine("Invalid selection, press return and select an option from the menu");
                    Console.ReadLine();
                }
            } while (true);
        }

        static void PrintMenu()
        {
            Console.Clear();
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
            Console.WriteLine(msg);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
