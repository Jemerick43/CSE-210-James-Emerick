/*
Name: < New Entry >
Purpose: <  Displays a random prompt to the user.
            Takes entry from user for Journal entry.>
Author: James Emerick
Date: 10/07/2023
*/
using System;



class NewEntry
{
    Random jerandomNumber = new();
    string[] jePrompts = { "What was the best part of your day? \n", "What went well today? \n", "What did you enjoy doing today? \n", "What are 3 things you are grateful for? \n", "How are you feeling? \n", "What did not go well today? \n" };

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
            string jeJournalEntry = jePrompts[jePromptIndex] + " " + jeTempEntry;
            jeList.Add(jeJournalEntry);
        }

        return jeList;

    }



}