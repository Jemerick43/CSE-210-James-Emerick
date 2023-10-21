/*
Name: Word
Purpose:Randomly choose a word instance from the scripture provided by Scripture
        Convert selected word(s) to blank spaces ('______')
        Store selected word locations in a variable.
Author: James Emerick
Date:
*/

class Word
{
    private Random jeRand = new();
    private int jeHideWords = 0;
    public List<int> RandomizeList(List<string> strings)
    {


        Console.WriteLine("Please enter the number of words you wish to hide: ");
        jeHideWords = int.Parse(Console.ReadLine());
        int i = 0;
        var jeHiddenStrings = new List<int>();
        while (i <= jeHideWords)
        {
            int jeLocation = jeRand.Next(0, strings.Count);
            i++;

        }


        return jeHiddenStrings;
    }
}