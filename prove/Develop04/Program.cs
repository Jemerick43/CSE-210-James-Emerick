/*
Name: Program
Purpose: Cycles through menu options and calls related classes when needed.
Author: James Emerick
Date: 10/30/2023
*/

class Program
{
    static void Main(string[] args)
    {
        bool jeIsUsingProgram = true;
        while (jeIsUsingProgram)
        {
            Console.WriteLine("Please enter a number corresponding to an activity: "); //Prints out menu items
            Console.WriteLine("\t1. Breathing Activity: ");
            Console.WriteLine("\t2. Listing Activity: ");
            Console.WriteLine("\t3. Reflection Activity: ");
            Console.WriteLine("\t0. Quit Program: ");
            int choiceNumber = int.Parse(Console.ReadLine()); //Get choice number from menu options

            if (choiceNumber == 1)
            {
                Console.Clear();
                string jeName = "Guided Breathing";
                Breathing activBreath = new("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", jeName);
                Console.WriteLine(activBreath.GetSummary());
                int jeDuration = activBreath.GetDuration();
                activBreath.DoPrepare(jeName);
                activBreath.DoActivity(jeDuration, "Breathe in...", "Breathe out...");
                activBreath.GetEndMessage(jeName, jeDuration);

            }
            else if (choiceNumber == 2)
            {
                Console.Clear();
                string jeName = "Listing Activity";
                Listing activList = new("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", jeName);
                Console.WriteLine(activList.GetSummary());
                int jeDuration = activList.GetDuration();
                activList.DoPrepare(jeName);
                int jeEntryNumber = activList.DoActivity(jeDuration);
                Console.WriteLine("The user successfully entered {0} answers!", jeEntryNumber);
                activList.GetEndMessage(jeName, jeDuration);

            }
            else if (choiceNumber == 3)
            {
                Console.Clear();
                string jeName = "Reflection Activity";
                Reflection activReflec = new("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", jeName);
                Console.WriteLine(activReflec.GetSummary());
                int jeDuration = activReflec.GetDuration();
                activReflec.DoPrepare(jeName);
                activReflec.DoActivity(jeDuration);
                activReflec.GetEndMessage(jeName, jeDuration);

            }
            else if (choiceNumber == 0)
            {
                jeIsUsingProgram = false;
            }
            else
            {
                Console.WriteLine("Error! Please enter a valid integer!");
            }
        }
    }
}