/*
Name: Display
Purpose: Handles Display and various Load/save methods used throughout program
Author: James Emerick
Date: 11/15/2023
*/
using System.IO;
class Display : Goals
{
    string[] _tempStrings;
    private string _menuText = "Select one of the following:\n\t1. Create new goal:\n\t2. List Goals:\n\t3. Save Goals:\n\t4. Load Goals:\n\t5. Record Event\n\t6. Quit:";
    private int _action;
    private string _fileName;
    private List<string> _listOfGoals = new();
    private List<Goals> _listOfGoalTypes = new();

    public int Menu() //handles display of menu and setting of the action of user
    {
        Console.WriteLine(_menuText);
        _action = int.Parse(Console.ReadLine());
        return _action;
    }

    public List<string> LoadGoals(string jeFileName)  // Reads a specified file and returns a list containing each line
    {
        _fileName = jeFileName;
        _tempStrings = System.IO.File.ReadAllLines(_fileName);
        foreach (string jeGoal in _tempStrings)
        {
            if (!jeGoal.Contains(','))
            {
                continue;
            }
            _listOfGoals.Add(jeGoal);
        }
        return _listOfGoals;
    }
    public List<Goals> LoadGoalTypes(string jeFileName)
    {
        _fileName = jeFileName;
        _tempStrings = System.IO.File.ReadAllLines(_fileName);
        foreach (string jeGoal in _listOfGoals)
        {
            if (!jeGoal.Contains(','))
            {
                continue;
            }
            else
            {
                string[] tempString = jeGoal.Split(':');
                if (tempString[0] == "Simple Goal")
                {
                    _listOfGoalTypes.Add(new Simple());
                }
                else if (tempString[0] == "Eternal Goal")
                {
                    _listOfGoalTypes.Add(new Eternal());
                }
                else if (tempString[0] == "Checklist Goal")
                {
                    _listOfGoalTypes.Add(new Checklist());
                }
            }

        }
        return _listOfGoalTypes;
    }
    public int LoadPoints(string jeFileName)
    {
        _fileName = jeFileName;
        _tempStrings = System.IO.File.ReadAllLines(_fileName);
        foreach (string jeGoal in _tempStrings)
        {
            if (!jeGoal.Contains(','))
            {
                _action = int.Parse(jeGoal);
                return _action;
            }
            else
            {
                continue;
            }
        }
        return _action;
    }
}