using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int menuChoice = 0;
        List<string> newGoal;
        bool loaded = false;
        string currentDirectory = Directory.GetCurrentDirectory();
        string[] textFiles = Directory.GetFiles(currentDirectory, "*.txt");
        Console.WriteLine("Hello! Welcome to EternalQuest, a goal setting and management game!");
        do
        {
            if (loaded)
            {
                Console.WriteLine($"\nLevel {goalManager.CalculateLevel()}: {goalManager.GetLevel()}");
                Console.WriteLine($"Points: {goalManager.CalculateScore()} ");
            }
            Console.WriteLine("\nPlease select an option below:");
            Console.WriteLine("1. Record Event");
            Console.WriteLine("2. Add goal");
            Console.WriteLine("3. Delete goal");
            Console.WriteLine("4. Show goals");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Quit");
            menuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (menuChoice == 1)
            {
                goalManager.DisplayGoals();
                Console.WriteLine("Which goal would you like to record?");
                int goalChoice = int.Parse(Console.ReadLine());
                goalManager.RecordEvent(goalChoice);

            }
            else if (menuChoice == 2)
            {
                int menu2Choice = 0;
                newGoal = [];
                Console.WriteLine("What type of goal would you like to create?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                while (menu2Choice < 1 || menu2Choice > 3)
                {
                    menu2Choice = int.Parse(Console.ReadLine());
                }
                if (menu2Choice == 1)
                {
                    newGoal.Add("S");
                }
                else if (menu2Choice == 2)
                {
                    newGoal.Add("E");
                }
                else if (menu2Choice == 3)
                {
                    newGoal.Add("C");
                }
                Console.WriteLine("Please name your goal:");
                newGoal.Add(Console.ReadLine());
                Console.WriteLine("Describe your goal:");
                newGoal.Add(Console.ReadLine());
                newGoal.Add("0");
                Console.WriteLine("How many points is one completion worth?");
                newGoal.Add(Console.ReadLine());
                if (menu2Choice == 3)
                {
                    Console.WriteLine("How many times should this be completed?");
                    newGoal.Add(Console.ReadLine());
                    Console.WriteLine("How many points is a full completion worth?");
                    newGoal.Add(Console.ReadLine());
                }
                goalManager.AddGoal(newGoal);
            }
            else if (menuChoice == 3)
            {
                goalManager.DisplayGoals();
                Console.WriteLine("Which goal would you like to delete?");
                int goalChoice = int.Parse(Console.ReadLine());
                goalManager.DeleteGoal(goalChoice);
            }
            else if (menuChoice == 4)
            {
                goalManager.DisplayGoals();
            }
            else if (menuChoice == 5)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                if (fileName.Contains(".txt"))
                {
                    goalManager.Save(fileName);
                }
                else
                {
                    Console.WriteLine("Error- file type is not text file. Please enter a text file name.");
                }
            }
            else if (menuChoice == 6)
            {
                Console.Write("What is your file name? ");
                string fileName = Console.ReadLine();
                if (fileName.Contains(".txt"))
                {
                    loaded = goalManager.Load(fileName);
                }
                else
                {
                    Console.WriteLine("Error- file type is not text file. Please enter a text file name.");
                }
            }
        } while (menuChoice != 7);
    }
}