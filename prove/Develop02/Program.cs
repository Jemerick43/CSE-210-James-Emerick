using System;

class Program
{
    static void Main(string[] args)
    {
        string jeMenuSelection = "";
        string file = "";
        List<string> entry = new List<string>();
        while (jeMenuSelection != "5")
        {
            Journal jeJournalFunction = new Journal();
            NewEntry jeEntryFunction = new NewEntry();
            jeMenuSelection = jeJournalFunction.DisplayMenu();

            if (jeMenuSelection == "1")
            {
                file = jeJournalFunction.InitializeJournal();
            }
            else if (jeMenuSelection == "2")
            {
                entry = jeEntryFunction.DisplayRandomPrompt();
            }
            else if (jeMenuSelection == "3")
            {
                jeJournalFunction.UpdateFile(file, entry);
            }
            else if (jeMenuSelection == "4")
            {
                jeJournalFunction.DisplayJournal(file);
            }
            else if (jeMenuSelection == "5")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Error! Please make sure you enter an integer between 1 and 5!\n");
                jeMenuSelection = "";
            }
        }
    }
}