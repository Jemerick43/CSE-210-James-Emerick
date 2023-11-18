/*
Name:
Purpose:
Author:
Date:
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        bool jeRunning = true;
        string jeFilename;
        Display GoalProgram = new();
        while (jeRunning)
        {

            List<Goals> goals = new List<Goals>();
            Console.WriteLine("You have {0} Points", GoalProgram.GetPoints());
            int choice = GoalProgram.Menu();
            if (choice == 1)
            {
                goals.Add(new Display.SetGoal());
            }
            else if (choice == 2)
            {
                jeFilename = GoalProgram.NewName();
                if (File.Exists(jeFilename))
                {
                    List<string> jeGoalsToList = GoalProgram.LoadGoals(jeFilename);
                    GoalProgram.DisplayGoals(jeGoalsToList);
                }
                else
                {
                    Console.WriteLine("No goals to display");
                }

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {
                jeFilename = GoalProgram.NewName();
                if (File.Exists(jeFilename))
                {
                    jeGoals = GoalProgram.LoadGoals(jeFilename);
                    Console.WriteLine("Goals successfully loaded!");
                }
                else
                {
                    File.Create(jeFilename);
                    Console.WriteLine("File not found, so new file created!");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Which goal would you like to update? ");
                foreach ()
            }
            else
            {
                running = false;
            }

        }

    }
}