/*
Name: < Journal >
Purpose: <  Displays menu options and takes input based on menu.
            Stores a filename to a public variable to later be written to.
            Calls New-Entry to begin a new writing session.
            Calls New-Entry to Save (update) the file.
            Displays Journal entries written to txt file.
            Closes program based on user input.
Author: James Emerick
Date:

*/
using System;

class Journal
{
    List<string> _journalEntries;
    string _fileName;
    static void Main(string[] args)
    {

    }

    public string DisplayMenu()
    {
        string je_menuSelection;
        Console.WriteLine("Please enter a number that corresponds with one of the following commands: \n");
        Console.WriteLine("1. Load Journal\n");
        Console.WriteLine("2. Create a new Journal Entry\n");
        Console.WriteLine("3. Save Journal\n");
        Console.WriteLine("4. Display Journal\n");
        Console.WriteLine("5. Quit Program\n");

        je_menuSelection = Console.ReadLine();

        return je_menuSelection;
    }

    public string InitializeJournal()
    {
        Console.WriteLine("Please enter the name of your file: ");
        string je_filename = Console.ReadLine();
        return je_filename;
    }

    public void RefreshFile(string _fileName, List<string> _journalEntries)
    {

    }

    public void DisplayJournal(List<string> _journalEntries)
    {

    }

    public string QuitProgram()
    {
        string je_quit;
        Console.WriteLine("Are you sure you want to quit the program? ");
        je_quit = Console.ReadLine();
        return je_quit;
    }
}


