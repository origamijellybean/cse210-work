using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment oct1 = new Assignment("Tyson", "Institute");
        MathAssignment oct2 = new MathAssignment("Tyson", "Programming", "Week05 Prepare", "Homework Function");
        WritingAssignment oct3 = new WritingAssignment("Tyson", "Genealogy", "Elizabeth Hovey");
        Console.WriteLine(oct1.GetSummary());
        Console.WriteLine($"\n{oct2.GetSummary()}\n{oct2.GetHomeworkList()}");
        Console.WriteLine($"\n{oct3.GetWritingInformation()}");

    }
}