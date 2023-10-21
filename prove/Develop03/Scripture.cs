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
    public string StoreScripture()
    {
        Console.WriteLine("Please enter the text to be memorized: \n");
        _ToMemorize = Console.ReadLine();
        return _ToMemorize;
    }

    public void DisplayScripture(string _scripture)
    {
        Console.WriteLine("{0}", _scripture);
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

    public List<string> RandomizeList(List<string> scripture)
    {
        Word jeNewWord = new();
        _Hidden = jeNewWord.RandomizeList(scripture);
        foreach (int jeWordRef in _Hidden)
        {
            scripture[jeWordRef] = "_____";
        }


        return scripture;
    }

    public bool IsStringHidden(List<string> scripture, List<int> hidden)
    {

    }

}