using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.Write("Enter your grade as num (ex. 65): ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        if (number >= 90)
            letter = "A";
        else if (number >= 80)
            letter = "B";
        else if (number >= 70)
            letter = "C";
        else if (number >= 60)
            letter = "D";
        else
            letter = "F";
        Console.WriteLine($"You earned a {letter}.");

        if (number >= 70)
            Console.WriteLine("Congratulations for passing!");
        else
            Console.WriteLine("C or better to pass. You can get it!");
    }
}