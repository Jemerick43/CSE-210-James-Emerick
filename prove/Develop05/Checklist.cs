/*
Name: Checklist
Purpose: Provides functionality for goals which require completion of certain tasks
Author: James Emerick
Date: 11/18/2023
*/
class Checklist : Goals
{
    int _points;
    private bool _isComplete;
    private string _goal;
    public Checklist() : base()
    {
    }
    public override string SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goal = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _goal = _goal + "," + Console.ReadLine();
        Console.WriteLine("How many times must you complete this goal for a bonus? ");
        _goal = _goal + "," + "0/" + Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with it? ");
        _goal = _goal + "," + Console.ReadLine();
        Console.WriteLine("What is the amount of bonus points associated with it? ");
        _goal = _goal + "," + Console.ReadLine();
        return "Checklist Goal:" + _goal;
    }
    public override string DisplayGoal(string goal)
    {
        string[] jeStrings = goal.Split(":");
        jeStrings = jeStrings[1].Split(",");
        _goal = jeStrings[0] + " ";
        _goal += "(" + jeStrings[1] + ") ";
        _goal += "Times to complete: " + jeStrings[2] + " ";
        _goal += "Points: " + jeStrings[3];
        _goal += "Bonus points: " + jeStrings[4];
        return _goal;
    }
    public override int AwardPoints(string jeGoal)
    {
        string[] jeStrings = jeGoal.Split(":");
        jeStrings = jeStrings[1].Split(",");
        string[] jeTempStrings = jeStrings[2].Split('/');
        int jeOne = int.Parse(jeTempStrings[0]);
        int jeTwo = int.Parse(jeTempStrings[1]);
        if (IsComplete(jeOne, jeTwo))
        {
            _points += int.Parse(jeStrings[4]);
        }
        _points += int.Parse(jeStrings[3]);
        return _points;
    }
    public override string IsGoalCompleted(string jeGoal)
    {
        string[] jeStrings = jeGoal.Split(":");
        string[] jeTempStrings = jeStrings[1].Split(",");
        string[] jeTempIntegers = jeTempStrings[2].Split('/');
        int jeTempInt = int.Parse(jeTempIntegers[0]);
        jeTempStrings[2] = String.Concat(jeTempInt++ + "/" + jeTempIntegers[1]);
        _goal = jeStrings[0] + ":" + String.Concat(jeTempStrings);
        return _goal;
    }
    public bool IsComplete(int jeNumberComplete, int jeNumberToComplete)
    {
        if (jeNumberComplete == jeNumberToComplete)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
        return _isComplete;
    }
}