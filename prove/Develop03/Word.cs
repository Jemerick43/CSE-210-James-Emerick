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
    private bool jeHidden;
    private List<string> _List;
    private string _NewString;
    public string RandomizeList(string strings)
    {
        List<string> tempList = ToList(strings);
        int rand = jeRand.Next(1, 3);
        int i = 0;
        while (i <= rand)
        {
            int location = jeRand.Next(0, tempList.Count);
            if (tempList[location].Contains('_'))
            {
                continue;
            }
            else
            {
                tempList[location] = "___";
                i++;
            }
        }
        strings = ToString(tempList);

        return strings;
    }

    public bool IsHidden(string script)
    {
        List<string> jeScript = ToList(script);
        foreach (string word in jeScript)
        {
            if (word.Contains('_'))
            {
                jeHidden = true;
            }
            else
            {
                jeHidden = false;
            }
        }
        return jeHidden;
    }

    public List<string> ToList(string _Scripture)
    {
        _List = _Scripture.Split(' ').ToList(); //Separates words by splitting the string at blank spaces (' ')
        return _List;
    }

    public string ToString(List<string> list)
    {
        _NewString = string.Join(" ", list.ToArray());
        return _NewString;
    }
}