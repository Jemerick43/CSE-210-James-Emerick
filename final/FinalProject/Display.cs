/*
Name: < Display >
Purpose: < Handles methods for displaying multi-line prompts to user >
Author: James Emerick
Date: 
*/

class Display
{
    private string _menuOutline = "Menu: \n\t 1. Add New Character\n\t 2. Edit Character(s)\n\t 3. Determine Enemies\n\t 4. Begin Combat\n\t 0. Quit Program";
    private int _defaultInt;
    private string _defaultString;
    public virtual string PromptFileLocation()
    {
        Console.WriteLine("Please enter the name of the file used to store character info: ");
        _defaultString = Console.ReadLine();

        return _defaultString;
    }
    public int MainMenu()
    {
        Console.WriteLine(_menuOutline);
        _defaultInt = int.Parse(Console.ReadLine());
        return _defaultInt;
    }
}