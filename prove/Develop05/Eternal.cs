/*
Name: Eternal
Purpose: Provides functionality for Eternal Goal types
Author: James Emerick
Date: 11/15/2023
*/
class Eternal : Goals
{
    private int _simplePoints;
    private string _goal;
    public override string SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goal = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _goal = _goal + "," + Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with it? ");
        _goal = _goal + "," + Console.ReadLine();
        return "Eternal Goal:" + _goal;
    }
    public override string DisplayGoal(string goal)
    {
        string[] jeStrings = goal.Split(":");
        jeStrings = jeStrings[1].Split(",");
        _goal = "[ ] ";
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
        return base.IsGoalCompleted(jeGoal);
    }
}
