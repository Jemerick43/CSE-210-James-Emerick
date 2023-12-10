using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool jeRunning = true;
        int jeMenuOption;
        Display menu = new();
        string jeFilename = menu.PromptFileLocation();
        List<string> jeCharacters = ReadFile.LoadData(jeFilename);
        List<string> jeEnemies = ReadFile.LoadData("enemies.txt");
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
                bool jeRunEnemyOption03 = true;
                Foes jeCombat = new();
                while (jeRunEnemyOption03)
                {
                    jeEnemies.Add(jeCombat.GetStatistics(jeCombat.GetClass()));
                    if (Display.PromptContinue("enemies") != "Y")
                    {
                        jeRunEnemyOption03 = false;
                    }
                }

                jeCombat.StoreEnemies(jeEnemies);
            }
            else if (jeMenuOption == 4)
            {
                Combat jeCombat = new();
                jeCombat.RunCombatLoop(jeCharacters);
            }
            else if (jeMenuOption == 5)
            {
                WriteFile jeWrite = new();
                jeWrite.SaveData(jeCharacters, jeFilename);
            }
            else if (jeMenuOption == 6)
            {
                jeCharacters = ReadFile.LoadData(jeFilename);
            }
            else
            {
                jeRunning = false;
            }
        }
    }
}