/* 
Name: Breathing
Purpose: Display prompts for user to breathe in and out.
Author: James Emerick
Date: 10/30/2023
*/

using System;
using System.Diagnostics;
using System.Threading;

class Breathing : Activity
{

    private string _name;
    private long _time = 1;

    public Breathing(string description, string name) : base(description, name)
    {
        _name = name;
    }
    public void DoActivity(int duration, string messageFirst, string messageLast)
    {
        Stopwatch runtime = new Stopwatch();
        runtime.Start();
        do
        {
            foreach (char letter in messageFirst)
            {
                Console.Write(letter);
                Thread.Sleep(400);
            }
            Console.WriteLine();
            _time = runtime.ElapsedMilliseconds;
            foreach (char letter in messageLast)
            {
                Console.Write(letter);
                Thread.Sleep(400);
            }
            Console.WriteLine();
            _time = runtime.ElapsedMilliseconds;
        } while (_time <= (duration * 1000));
        runtime.Stop();

    }
}