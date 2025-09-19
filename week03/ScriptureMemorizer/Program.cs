using System;
using System.Linq.Expressions;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        bool repeat = true;
        string response = "";
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