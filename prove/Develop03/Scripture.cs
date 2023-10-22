/*
Name: Scripture
Purpose:Displays the scripture provided by the user.
        Stores the scripture provided.
        Converts the provided scripture to a list
        Sets the scripture list to a new randomized list by calling 'Word'
        Convert list provided from 'Word' to a string. (this is the new scripture to display)
Author: James Emerick
Date:
*/

class Scripture
{
    private string _ToMemorize;
    private List<string> _List;
    private string _NewString;
    private List<int> _Hidden;
    private bool jeIsHidden;
    public string StoreScripture()
    {
        Console.WriteLine("Please enter the text to be memorized: ");
        _ToMemorize = Console.ReadLine();
        return _ToMemorize;
    }

    public void DisplayScripture(string _scripture)
    {
        Console.WriteLine("\n\n{0}", _scripture);
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

    public string RandomizeList(string scripture)
    {
        Word jeNewWord = new();
        _NewString = jeNewWord.RandomizeList(scripture);
        return _NewString;
    }

    public bool IsStringHidden(string scripture)
    {
        Word jeNewWord = new();
        jeIsHidden = jeNewWord.IsHidden(scripture);
        if (jeIsHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}