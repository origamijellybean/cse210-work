
using System.Reflection.Metadata.Ecma335;

public class Activity
{


    private int _timeInSeconds;
    private string _activityType;
    private string _endingMessage;
    private int _pauseTimeInSeconds = 5;
    private string _description;

    public void SetTimeInSeconds()
    {
        Console.Write("How many seconds would you like to spend on this activity? ");
        try
        {
            _timeInSeconds = int.Parse(Console.ReadLine());
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Please enter an integer!");
        }
        Console.Clear();
    }
    public int GetTimeInSeconds()
    {
        return _timeInSeconds;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetActivityType(string activityType)
    {
        _activityType = activityType;
    }
    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void Pause(int seconds)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write("\b");
        }
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write(" ");
        }
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write("\b");
        }
    }
    public void ActivityStart()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityType} Activity!\n\n{GetDescription()}\n");
        SetTimeInSeconds();
        Console.WriteLine("Get ready...");
        Pause(_pauseTimeInSeconds);
    }
    public void ActivityEnd()
    {
        Console.WriteLine("\nWell done!!");
        Pause(_pauseTimeInSeconds);
        Console.WriteLine($"\nYou have completed another {GetTimeInSeconds()} seconds of the {_activityType} Activity!");
        Pause(_pauseTimeInSeconds);
        Console.Clear();
    }
}   