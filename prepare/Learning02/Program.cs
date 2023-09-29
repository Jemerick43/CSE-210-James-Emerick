using System;

class Program
{
    static void Main(string[] args)
    {


        Job job1 = new Job();
        job1._jejobTitle = "Software Engineer";
        job1._jeCompany = "(Microsoft)";
        job1._jestartYear = 2019;
        job1._jeendYear = 2022;

        Job job2 = new Job();
        job2._jejobTitle = "Programmer";
        job2._jeCompany = "(Apple)";
        job2._jestartYear = 2022;
        job2._jeendYear = 2023;

        Resume resume1 = new Resume();
        resume1._jeName = "James Emerick";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}