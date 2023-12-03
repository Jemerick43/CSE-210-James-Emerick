/*
Name: < Class >
Purpose: <  Contains parent methods for Fighter, Wizard, Archer classes
            Baseline for creating and editing new classes.
Author: James Emerick
Date: 
*/

using System.Net;
using System.Runtime.CompilerServices;

class CharacterClass
{
    private string _classes = "Fighter, Wizard, or Archer";
    private string[] _classType;
    private string _defaultString;
    private int _defaultInt;

    public string GetClass()
    {
        Console.WriteLine("Please enter the name of your Character: ");
        _classType[0] = Console.ReadLine();
        Console.WriteLine("Please enter the type of class you wish to create ({0})", _classes);
        _classType[1] = Console.ReadLine();
        _defaultString = _classType[0] + ";" + _classType[1];
        return _defaultString;
    }
    public string GetStatistics(string jeCharacter)
    {
        Console.WriteLine("Please enter the relavent scores for each of your character's attributes\n(Strength, Dexterity, Constitution, Inteligence, Wisdom, and Charisma)");
        Console.WriteLine("Also ensure that each integer entered is separated by commas (ex: 10,10,10,10,10,10)");
        _defaultString = Console.ReadLine();
        jeCharacter += ":" + _defaultString;
        return jeCharacter;
    }
    private int SelectClassForEditing(List<string> jeCharacters)
    {
        _defaultInt = 0;
        Console.WriteLine("Please select a character to edit from the following list: ");
        foreach (string jeLine in jeCharacters)
        {
            _defaultInt += 1;
            Console.Write("{0}.", _defaultInt); //prints formatting to prompt for integer input
            string[] jeChar = jeLine.Split(';'); //Splits character name off from each line
            Console.Write("\t{0}.\n", jeChar[0]); //Prints character name to console
        }
        _defaultInt = int.Parse(Console.ReadLine());
        return _defaultInt;

    }
    public List<string> EditCharacter(List<string> jeCharacters)
    {
        _defaultInt = SelectClassForEditing(jeCharacters);
        Console.WriteLine("Character ready for overwrite!");
        Console.WriteLine("Would you like to change your character's name or class? (Y or N)");
        _defaultString = "Y";
        _classType = jeCharacters[_defaultInt].Split(":");            //--saves the split jeCharacters data to class variable
        string[] jeTempString = jeCharacters[_defaultInt].Split(":"); //--duplicates info to be displayed later
        if (_defaultString == Console.ReadLine())
        {
            _classType[0] = GetClass();                               //--updates the base character info
            Console.WriteLine("Character was changed from {0} to {1}", jeTempString[0], _classType[0]);
        }
        Console.WriteLine("Would you like to edit your character's statistics? (Y or N)");
        if (_defaultString == Console.ReadLine()) //if user decides to edit statistics, calls relavent method
        {
            jeCharacters[_defaultInt] = GetStatistics(_classType[0]);
        }
        else
        {
            jeCharacters[_defaultInt] = String.Join(":", _classType); //else, updates jeCharacters by re-attaching _classType
        }
        return jeCharacters;
    }

}