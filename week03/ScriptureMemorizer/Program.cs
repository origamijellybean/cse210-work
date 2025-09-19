//I changed the program to only delete words that have not previously been deleted. I also changed it so user can enter a scripture.

using System;
using System.Linq.Expressions;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        bool repeat;
        string response;
        Console.WriteLine("Welcome to scripture memorizer!");
        Console.WriteLine("Please first enter scripture reference:");     
        Reference reference = new Reference(Console.ReadLine());
        Console.WriteLine("Next, enter scripture(s):");
        Scripture scripture = new Scripture(Console.ReadLine());
        do
        {
            Console.Clear();
            reference.DisplayReference();
            scripture.DisplayScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to quit: ");
            response = Console.ReadLine();
            if (response == "quit")
            {
                repeat = false;
            }
            else
            {
                repeat = scripture.RemoveWords();
            }

        } while (repeat == true);
    }
}