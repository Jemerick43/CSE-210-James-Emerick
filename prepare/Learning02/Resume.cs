using System;
//Keeps track of the company, job title, start year, and end year
//of an individual. Displays this info in format
//"Job Title (Company) StartYear-EndYear"
//
//

class Resume
{
    public string _jeName = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume(){
        Console.WriteLine($"Name: {_jeName}");
        Console.WriteLine($"Jobs: ");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }

}
