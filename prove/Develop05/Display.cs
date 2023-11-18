/*
Name: Display
Purpose: Handles Display and various Load/save methods used throughout program
Author: James Emerick
Date: 11/15/2023
*/
class Display : Goals
{
    private string _privateString;
    private int _points = 0;
    private List<string> _listOfGoals = new();
    private string _fileName;
    private string _menuText = "Select one of the following:\n\t1. Create new goal:\n\t2. List Goals:\n\t 3. Save Goals:\n\t 4. Load Goals:\n\t 5. Record Event\n\t6. Quit:";
    private int _action;
    private int _privateInt;
    public Display() : base()
    {

    }

    public int Menu() //handles display of menu and setting of the action of user
    {
        Console.WriteLine(_menuText);
        _action = int.Parse(Console.ReadLine());
        return _action;
    }

    public void DisplayGoals(List<string> jeGoals) // displays each goal written to file
    {
        foreach (string jeLine in jeGoals)
        {
            if (jeLine.Contains(','))
            {
                Console.WriteLine(jeLine);
            }
            else
            { //special output for points (saved without a comma in its line)
                /*  continue; //CHANGE MEEEEEE */
            }
        }
    }
    public override string NewName()
    {
        Console.WriteLine("Please enter the name of the file to load: ");
        _privateString = Console.ReadLine();
        return _privateString;
    }
    public List<string> LoadGoals(string jeFilename)  // Reads a specified file and returns a list containing each line
    {
        _fileName = jeFilename;
        _listOfGoals = (List<string>)System.IO.File.ReadLines(_fileName);
        return _listOfGoals;
    }

    public void SaveGoals(List<string> jeGoals, string jeFilename)
    {
        _fileName = jeFilename;
        using (StreamWriter jeFile = new StreamWriter(_fileName))
        {
            foreach (string jeLine in jeGoals)
            {
                jeFile.WriteLine(jeLine);
            }
        }
    }
    public override int NewPoints()
    {
        Console.WriteLine("How many points does the user get if they complete the checklist?");
        _privateInt = int.Parse(Console.ReadLine());
        return _privateInt;
    }

    public List<string> SetGoal()
    {
        Goals parent = new();
        _privateInt = parent.NewGoal();
        if (_privateInt == 3)
        {
            _privateString = 3 + "," + parent.NewName() + "," + "[ ]" + parent.NewPoints() + "," + 0 + "/" + parent.TimesToComplete() + "," + NewPoints();
        }
        else
        {
            _privateString = parent.NewGoal() + "," + parent.NewName() + "[ ]" + "," + parent.NewPoints();
        }
        _listOfGoals.Add(_privateString);
        return _listOfGoals;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
}