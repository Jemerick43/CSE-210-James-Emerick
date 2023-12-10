/*
Name: < Display >
Purpose: < Handles methods for displaying multi-line prompts to user >
Author: James Emerick
Date: 
*/

class Display
{
    private string _menuOutline = "Menu: \n\t 1. Add New Character\n\t 2. Edit Character(s)\n\t 3. Determine Enemies\n\t 4. Begin Combat\n\t 5. Save Character Data\n\t 6. Load Character Data\n\t 0. Quit Program";
    private int _defaultInt;
    private string _defaultString;
    public string PromptFileLocation()
    {
        Console.WriteLine("Please enter the name of the file used to store character info: ");
        _defaultString = Console.ReadLine();

        return _defaultString;
    }
    public static string PromptContinue(string jeType)
    {
        Console.WriteLine("Would you like to add more {0}? ", jeType);
        return Console.ReadLine();
    }
    public int MainMenu()
    {
        Console.WriteLine(_menuOutline);
        _defaultInt = int.Parse(Console.ReadLine());
        return _defaultInt;
    }
}