/*
Name: Goals
Purpose: Parent function for all goal types. Sets default methods and attributes
Author: James Emerick
Date: 11/15/2023
*/

class Goals
{
    private int _iterate;
    private string _name;
    private string _description;
    private int _type;
    private int _points;
    private bool _ifComplete;
    private List<string> _goalTypes = new() { "Simple Goal", "Eternal Goal", "Checklist Goal" };
    private List<string> _goals = new();
    public int NewGoal() //Iterates through default list of goal types and gets user input for which type they would like to create
    {
        foreach (string jeGoal in _goalTypes)
        {
            ++_iterate;
            Console.WriteLine("{0}. {1}", _iterate, jeGoal);
        }
        Console.WriteLine("Which type of goal would you like to create?");
        _type = int.Parse(Console.ReadLine());
        return _type;
    }
    public virtual string NewName() //Obtains name of goal from user
    {
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        return _name;
    }
    public int TimesToComplete() //Obtains the number of times to complete a list goal from user
    {
        Console.WriteLine("How many times must you complete this goal? ");
        _type = int.Parse(Console.ReadLine());
        return _type;
    }
    public virtual int NewPoints()
    { //Method to obtain point attribute from user.
        Console.WriteLine("What are the associated points?");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }
    public virtual int IterateGoalCompletion(int jePoints, int jeBonusPoints)
    {
        return 0;
    }
    public bool IsComplete()
    {
        _ifComplete = true;
        return _ifComplete;
    }

}