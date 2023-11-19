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
        int jePoints = 0;
        Display GoalProgram = new();
        List<Goals> jeGoals = new();
        List<string> jeGoal = new();
        while (jeRunning)
        {
            Console.WriteLine("You have {0} Points", jePoints);
            int choice = GoalProgram.Menu();
            if (choice == 1)
            {
                int jeGoalType = GoalProgram.GetGoal();
                if (jeGoalType == 1)
                {
                    jeGoals.Add(new Simple());
                    jeGoal.Add(jeGoals[jeGoals.Count - 1].SetGoal());
                }
                else if (jeGoalType == 2)
                {
                    jeGoals.Add(new Eternal());
                    jeGoal.Add(jeGoals[jeGoals.Count - 1].SetGoal());

                }
                else
                {
                    jeGoals.Add(new Checklist());
                    jeGoal.Add(jeGoals[jeGoals.Count - 1].SetGoal());
                }
            }
            else if (choice == 2)
            {
                int i = 0;
                foreach (Goals jeGoalTemplate in jeGoals)
                {
                    string jeStringToDisplay = jeGoalTemplate.DisplayGoal(jeGoal[i]);
                    Console.WriteLine(jeStringToDisplay);
                    i++;
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the Filename for the Goal file? ");
                jeFilename = Console.ReadLine();
                using (StreamWriter jeFile = new StreamWriter(jeFilename))
                {
                    jeFile.WriteLine(jePoints);
                    foreach (string jeLine in jeGoal)
                    {
                        jeFile.WriteLine(jeLine);
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the Filename for the Goal File? ");
                jeFilename = Console.ReadLine();
                if (File.Exists(jeFilename))
                {
                    jePoints = GoalProgram.LoadPoints(jeFilename);
                    jeGoal = GoalProgram.LoadGoals(jeFilename);
                    jeGoals = GoalProgram.LoadGoalTypes(jeFilename);
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
                Console.WriteLine("The goals are: ");
                int i = 0;
                foreach (string jeGoalLine in jeGoal)
                {
                    string jeStringToDisplay = GoalProgram.DisplayGoalName(jeGoal[i]);
                    i++;
                    Console.WriteLine("{0}. {1}", i, jeStringToDisplay);
                }
                int jeDecision = GoalProgram.GetGoalIndicator();
                jePoints += jeGoals[jeDecision - 1].AwardPoints(jeGoal[jeDecision - 1]);
                jeGoal[jeDecision - 1] = jeGoals[jeDecision - 1].IsGoalCompleted(jeGoal[jeDecision - 1]);
            }
            else
            {
                jeRunning = false;
            }

        }

    }
}