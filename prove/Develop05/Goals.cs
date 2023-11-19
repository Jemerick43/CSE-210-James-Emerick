/*
Name: Goals
Purpose: Parent function for all goal types. Sets default methods and attributes
Author: James Emerick
Date: 11/15/2023
*/


abstract public class Goals
{
    private bool _isComplete;
    private readonly int _points;
    private int _goalType;
    private string _goal;
    private List<string> _goalTypes = new() { "Simple Goal", "Eternal Goal", "Checklist Goal" };
    private List<string> _goals;
    public virtual int GetGoal()
    {
        Console.WriteLine("The types of Goals are:\n\t1. {0}\n\t2. {1}\n\t3. {2}", _goalTypes[0], _goalTypes[1], _goalTypes[2]);
        Console.WriteLine("Which type of goal would you like to create? (answer 1, 2, or 3)");
        _goalType = int.Parse(Console.ReadLine());
        return _goalType;
    }
    public virtual string SetGoal()
    {
        return _goal;
    }
    public virtual string DisplayGoal(string goal)
    {
        _goal = goal;
        return _goal;
    }
    public string DisplayGoalName(string goal)
    {
        string[] jeStrings = goal.Split(":");
        jeStrings = jeStrings[1].Split(",");
        return jeStrings[0];
    }
    public int GetGoalIndicator()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        _goalType = int.Parse(Console.ReadLine());
        return _goalType;
    }
    public virtual string IsGoalCompleted(string jeGoal)
    {
        return jeGoal;
    }
    public virtual int AwardPoints(string jeGoal)
    {
        return _points;
    }
}
