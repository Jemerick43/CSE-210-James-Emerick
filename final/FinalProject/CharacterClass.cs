/*
Name: < CharacterClass >
Purpose: <  Contains parent methods for Fighter, Wizard, Archer classes
            Baseline for creating and editing new classes.
Author: James Emerick
Date: 
*/

class CharacterClass
{
    private string _classes = "Fighter, Wizard, or Archer";
    private string _classType;
    private string _defaultString;
    private int _defaultInt;

    public virtual string GetClass()
    {
        Console.WriteLine("Please enter the name of your Character: ");
        _classType = Console.ReadLine();
        Console.WriteLine("Please enter the type of class you wish to create ({0})", _classes);
        _classType += ';' + Console.ReadLine();
        _defaultString = _classType;
        return _defaultString;
    }
    public virtual string GetStatistics(string jeCharacter)
    {
        if (jeCharacter.Contains("Vs;"))
        {
            Console.WriteLine("Please enter the relavent scores for each of your character's attributes\n(Strength, Dexterity, Constitution, Inteligence, Wisdom, Charisma, and Current Hp)");
            Console.WriteLine("Also ensure that each integer entered is separated by commas (ex: 10,10,10,10,10,10,13)");
        }
        else
        {
            Console.WriteLine("Please enter the relavent scores for each of your creature's attributes\n(Strength, Dexterity, Constitution, Inteligence, Wisdom, Charisma, and Current Hp)");
            Console.WriteLine("Also ensure that each integer entered is separated by commas (ex: 10,10,10,10,10,10,13)");
        }

        _defaultString = Console.ReadLine();
        jeCharacter += ":" + _defaultString;
        return jeCharacter;
    }
    private int SelectClassForEditing(List<string> jeCharacters)
    {
        _defaultInt = 0;
        if (jeCharacters.Contains("Vs;"))
        {
            Console.WriteLine("Please select a creature to edit from the following list (1, 2, 3, etc): ");
        }
        else
        {
            Console.WriteLine("Please select a character to edit from the following list (1, 2, 3, etc): ");
        }
        foreach (string jeLine in jeCharacters)
        {
            _defaultInt += 1;
            Console.Write("{0}.", _defaultInt); //prints formatting to prompt for integer input
            string[] jeChar = jeLine.Split(':'); //Splits character name off from each line
            Console.Write("\t{0}.\n", jeChar[0]); //Prints character name to console
        }
        _defaultInt = int.Parse(Console.ReadLine());
        return _defaultInt;

    }
    public virtual List<string> EditCharacter(List<string> jeCharacters)
    {
        _defaultInt = SelectClassForEditing(jeCharacters);
        bool jeParty = !jeCharacters.Contains("Vs:");
        if (jeParty)
        {
            Console.WriteLine("Character ready for overwrite!");
            Console.WriteLine("Would you like to change your character's name or class? (Y or N)");
        }
        else
        {
            Console.WriteLine("Creature ready for overwrite!");
        }
        _defaultString = "Y";
        string[] jeClass = jeCharacters[_defaultInt].Split(":");            //--saves the split jeCharacters data to class variable
        string[] jeTempString = jeCharacters[_defaultInt].Split(":"); //--duplicates info to be displayed later
        if (_defaultString == Console.ReadLine())
        {
            jeClass[0] = GetClass();                               //--updates the base character info
            Console.WriteLine("Data was changed from {0} to {1}", jeTempString[0], _classType[0]);
        }
        if (jeParty)
        {
            Console.WriteLine("Would you like to edit your character's statistics? (Y or N)");
        }
        else
        {
            Console.WriteLine("Would you like to edit your creature's statistics? (Y or N)");
        }
        if (_defaultString == Console.ReadLine()) //if user decides to edit statistics, calls relavent method
        {
            jeCharacters[_defaultInt] = GetStatistics(jeClass[0]);
        }
        else
        {
            jeCharacters[_defaultInt] = String.Join(":", _classType); //else, updates jeCharacters by re-attaching _classType
        }
        return jeCharacters;
    }


}