/*
Name:
Purpose:
Author:
Date:
*/

using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Scripture jeNewScripture = new();
        Reference jeNewRef = new();
        bool jeIsRunning = true;
        int i = 0;
        string jeRef;
        string jeScript;
        jeRef = jeNewRef.StoreReference();
        jeScript = jeNewScripture.StoreScripture();
        bool jeHide = false;
        while (jeIsRunning == true)
        {
            i++;
            if (i == 2)
            {
                jeHide = jeNewRef.HiddenReference();
                jeNewRef.DisplayReference(jeRef, jeHide);
                jeNewScripture.DisplayScripture(jeScript);
            }
            else
            {
                jeNewRef.DisplayReference(jeRef, jeHide);
                jeNewScripture.DisplayScripture(jeScript);
            }
            Console.WriteLine("Press enter to randomize list, enter 0 to quit program");
            string jeRandom = Console.ReadLine();
            if (jeNewScripture.IsStringHidden(jeScript) == true)
            {
                jeNewRef.DisplayReference(jeRef, jeHide);
                jeNewScripture.DisplayScripture(jeScript);
                jeIsRunning = false;
                continue;
            }
            else if (jeRandom == "")
            {
                jeScript = jeNewScripture.RandomizeList(jeScript);
            }
            else
            {
                jeIsRunning = false;
            }



        }
    }
}