/* 
Name: Activity
Purpose: Contains parent files needed by Breathing, Reflection, and Listing.
        Sets Timeframe, Displays Summaries, Pause function, Displays End Messages,
        Displays Countdown + Waiting Spinner, Gets random prompt.
Author: James Emerick
Date: 10/30/2023
*/
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Activity
{
        private int _jeDuration;
        private string _jeDescription;
        private string _jeName;
        private string _jeEndMessage;
        private string _jePrepMessage;
        public Activity(string description, string name)
        { // Constructor which initializes all child variables to be used in later code
                _jeDescription = description;
                _jeName = name;
        }

        public int GetDuration()
        {
                Console.WriteLine("Please enter the desired activity duration in seconds: ");
                _jeDuration = int.Parse(Console.ReadLine());
                return _jeDuration;
        }

        protected string GetDescription(string description)
        {
                _jeDescription = description;
                return _jeDescription;
        }

        protected string GetName(string name)
        {
                _jeName = name;
                return _jeName;
        }

        public void GetEndMessage(string activity, int duration)
        {
                _jeEndMessage = "Good Job!! You have just completed " + activity + " for " + duration + " seconds!";
                foreach (char letter in _jeEndMessage)
                {
                        Console.Write(letter);
                        Thread.Sleep(50);
                        if (letter == '!')
                        {
                                Thread.Sleep(200);
                        }
                }
                Console.WriteLine();
                Thread.Sleep(500);
        }

        public string GetSummary()
        {
                return _jeName + ":\n" + _jeDescription;
        }

        public void DoPrepare(string name)
        {
                _jePrepMessage = "Prepare for " + name + "...";
                Console.WriteLine();
                foreach (char letter in _jePrepMessage)
                {
                        Console.Write(letter);
                        Thread.Sleep(50);
                }
                Console.WriteLine();
                Thread.Sleep(500);
        }
}