using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool jeRunning = true;
        int jeMenuOption;
        List<string> jeCharacters = new();
        Display menu = new();
        string jeFilename = menu.PromptFileLocation();
        while (jeRunning)
        {
            jeMenuOption = menu.MainMenu();
            if (jeMenuOption == 1)
            {
                CharacterClass jeBasic = new();
                jeCharacters.Add(jeBasic.GetStatistics(jeBasic.GetClass()));
            }
            else if (jeMenuOption == 2)
            {
                if (jeCharacters.Count != 0)
                {
                    CharacterClass jeBasic = new();
                    jeCharacters = jeBasic.EditCharacter(jeCharacters);
                }
                else
                {
                    Console.WriteLine("Error! No information available to be edited!");
                }
            }
            else if (jeMenuOption == 3)
            {

            }
            else if (jeMenuOption == 4)
            {

            }
            else
            {
                jeRunning = false;
            }
        }
    }
}