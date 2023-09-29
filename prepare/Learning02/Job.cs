using System;



public class Job
{
    public string _jeCompany = "";
    public string _jejobTitle = "";
    public int _jestartYear = 0;
    public int _jeendYear = 0;

    public void DisplayJob(){
        Console.WriteLine($"{_jejobTitle} {_jeCompany} {_jestartYear}-{_jeendYear}");
    }
    


}
