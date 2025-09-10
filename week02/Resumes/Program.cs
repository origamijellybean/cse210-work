using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Treehouse Cookies";
        job1._jobTitle = "Cookie Packager";
        job1._startYear = 2021;
        job1._endYear = 2021;
        Job job2 = new Job();
        job2._company = "McDonalds";
        job2._jobTitle = "Crew Member";
        job2._startYear = 2025;
        job2._endYear = 2025;
        Resume resume1 = new Resume();
        resume1._name = "Tyson Hunter";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}