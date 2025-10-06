//I added a class called RandomSelection for random lists for the questions in the reflection activity, to not repeat the questions.

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Project.");
            Console.WriteLine("Please select an activity below. Type the number then hit enter:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch (InvalidCastException)
            {
                selection = 0;
            }
            if (selection == 1)
            {
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Breath();

            }
            else if (selection == 2)
            {
                ReflectionActivity reflection1 = new ReflectionActivity();
                reflection1.Reflect();
            }
            else if (selection == 3)
            {
                ListingActivity listing1 = new ListingActivity();
                listing1.List();
            }
            else if (selection != 4)
            {
                Console.WriteLine("Please enter a digit 1-4");
                selection = 0;
            }

        } while (selection != 4);
    }
}