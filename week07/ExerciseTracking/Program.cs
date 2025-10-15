using System;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("12 Oct 2025", 30, 3);
        Cycling cycling1 = new Cycling("13 Oct 2025", 25, 12);
        Swimming swimming1 = new Swimming("14 Oct 2025", 18, 3.1);
        List<Activity> activities1 = [running1, cycling1, swimming1];
        foreach (Activity activity in activities1)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}