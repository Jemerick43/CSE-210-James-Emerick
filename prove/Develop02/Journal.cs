/*
Name: < Journal >
Purpose: <  Displays menu options and takes input based on menu.
            Stores a filename to a public variable to later be written to.
            Calls New-Entry to begin a new writing session.
            Calls New-Entry to Save (update) the file.
            Displays Journal entries written to txt file.
            Closes program based on user input.
Author: James Emerick
Date: 10/07/2023
*/
using System;
using System.IO;
using System.Text;

class Journal
{
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

    public void DisplayJournal(string _fileName)
    {
        string jepath = _fileName;
        string jejournal = File.ReadAllText(jepath);
        Console.WriteLine(jejournal);
    }

    public void UpdateFile(string _newEntry, List<string> _journalEntries)
    {
        var jeNow = DateTime.Now; // initialize today's date
        using (StreamWriter jeWriter = File.AppendText(_newEntry)) //initialize writer
        {
            jeWriter.WriteLine(jeNow);                             //write today's date to file
        }
        string jePath = _newEntry;  //initialize filename as a string
        foreach (string entry in _journalEntries) //loop through list of strings
        {
            using (StreamWriter jeWriter = File.AppendText(_newEntry)) //initialize writer
            {
                jeWriter.WriteLine(entry); //write current string to file
            }
        }

    }

    public string QuitProgram()
    {
        string je_quit;
        Console.WriteLine("Are you sure you want to quit the program? ");
        je_quit = Console.ReadLine();
        return je_quit;
    }
}


