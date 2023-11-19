/*
Name: Simple
Purpose: Provides behavior for goals which require only completion and points
Author: James Emerick
Date: 11/18/2023
*/
class Simple : Goals
{
    private int _simplePoints;
    private string _goal;
    public Simple() : base()
    {
    }
    public override string SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goal = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _goal = _goal + "," + Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with it? ");
        _goal = _goal + "," + Console.ReadLine() + "," + "False";
        return "Simple Goal:" + _goal;
    }
    public override string DisplayGoal(string goal)
    {
        string[] jeStrings = goal.Split(":");
        jeStrings = jeStrings[1].Split(",");
        if (jeStrings[3] == "TRUE")
        {
            _goal = "[X] ";
        }
        else
        {
            _goal = "[ ] ";
        }
        _goal += jeStrings[0] + " ";
        _goal += "(" + jeStrings[1] + ") ";
        return _goal;
    }
    public override int AwardPoints(string jeGoal)
    {
        string[] jeStrings = jeGoal.Split(":");
        jeStrings = jeStrings[1].Split(",");
        _simplePoints = int.Parse(jeStrings[2]);
        return _simplePoints;
    }
    public override string IsGoalCompleted(string jeGoal)
    {
        string[] jeStrings = jeGoal.Split(":");
        string[] jeTempStrings = jeStrings[1].Split(",");
        jeTempStrings[3] = "TRUE";
        jeStrings[1] = string.Concat(jeTempStrings);
        _goal = jeStrings[0] + ":" + jeStrings[1];
        return _goal;
    }
}