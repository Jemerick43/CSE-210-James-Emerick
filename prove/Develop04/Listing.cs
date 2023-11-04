/* 
Name: Listing
Purpose: Guides user in positive thinking by having user list
as many strengths / positive aspects in a set amount of time. (Takes this as input)
Afterwards displays number of inputs to this list.
Author: James Emerick
Date: 10/30/2023
*/
class Listing : Activity
{
    private string _name;
    private int _i;
    private List<string> _strings = new() {"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    public Listing(string description, string name) : base(description, name)
    {
        _name = name;
    }

    public int DoActivity(int runTime)
    {
        Random jeRand = new();
        int jeRandLocation = jeRand.Next(0, _strings.Count - 1);
        foreach (char letter in _strings[jeRandLocation])
        {
            Console.Write(letter);
            Thread.Sleep(50);
        }
        Console.Write("\n");
        DateTime jeStartActivity = DateTime.Now;
        DateTime stoptime = jeStartActivity.AddSeconds(6);
        _i = 6;
        Console.WriteLine("Activity starts in... ");
        while (DateTime.Now < stoptime)
        {
            Console.Write(_i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); //Clears the message to be re-written
            _i -= 1;
        }
        jeStartActivity = DateTime.Now;
        stoptime = jeStartActivity.AddSeconds(runTime);
        _i = 0;
        while (DateTime.Now <= stoptime)
        {
            Console.ReadLine();
            _i += 1;
        }
        return _i;
    }

}