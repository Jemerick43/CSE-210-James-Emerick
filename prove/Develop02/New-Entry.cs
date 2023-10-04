/*
Name: < New Entry >
Purpose: <  Displays a random prompt to the user.
            Takes entry from user for Journal entry.
            Appends the entry to a designated txt file.>
Author: James Emerick
Date:
*/
using System;



class NewEntry
{
    Random jerandomNumber = new Random();
    string[] jePrompts = { "What was the best part of your day? ", "What went well today? ", "What did you enjoy doing today? " };
    static void main(string[] args)
    {

    }

    public List<string> DisplayRandomPrompt()
    {
        var jeList = new List<string>();
        Console.WriteLine("How many prompts would you like? (answer as an integer)\n");
        string jePromptQuantity = Console.ReadLine();
        int jePromptInt = int.Parse(jePromptQuantity);
        for (int i = 1; i <= jePromptInt; i++)
        {
            int jePromptIndex = jerandomNumber.Next(jePrompts.Length);
            Console.WriteLine("{0}", jePrompts[jePromptIndex]);
            string jeTempEntry = Console.ReadLine();
            jeList.Add(jeTempEntry);
        }
        return jeList;

    }

    public string UpdateFile(string _newEntry, List<string> _journalEntries)
    {
        string jeNewEntry = "";
        return jeNewEntry;
    }


}