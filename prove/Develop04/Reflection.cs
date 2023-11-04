/* 
Name: Reflection
Purpose: Prompts user to consider a certain experience when they were successful or demonstrated strength.
 Then, prompts them with questions to reflect more deeply about details of this experience.
Author: James Emerick
Date: 10/30/2023
*/

class Reflection : Activity
{
    private string _jeName;
    private List<string> _jeThinkList = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
    private List<string> _jePromptList = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
    public Reflection(string description, string name) : base(description, name)
    {
        _jeName = name;
    }

    public void DoActivity(int runTime)
    {
        Random jeRand = new();
        int jeRandLocation = jeRand.Next(0, _jeThinkList.Count - 1);
        foreach (char letter in _jeThinkList[jeRandLocation])
        {
            Console.Write(letter);
            Thread.Sleep(50);
        }
        Console.WriteLine();
        DateTime jeStartActivity = DateTime.Now;
        DateTime stoptime = jeStartActivity.AddSeconds(runTime);
        while (DateTime.Now < stoptime)
        {
            jeRandLocation = jeRand.Next(0, _jePromptList.Count - 1);
            foreach (char letter in _jePromptList[jeRandLocation])
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.Write(':');
            for (int i = 0; i <= 20; i++)
            {
                Console.Write("O");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("D");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("P");
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

    }

}