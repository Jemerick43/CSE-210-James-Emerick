/*
Name: < ReadFile >
Purpose: <  Contains parent methods for Fighter, Wizard, Archer classes
            Baseline for creating and editing new classes.
Author: James Emerick
Date: 
*/
class WriteFile
{
    private string[] _Strings = null;
    private string _FileName;
    public void SaveData(List<string> jeUserData, string jeNameForFile)
    {
        _FileName = jeNameForFile;
        if (File.Exists(jeNameForFile))
        {
            Console.WriteLine("Are you sure you wish to save? All previous data will be overwritten! (Y/N)");
            if ("Y" == Console.ReadLine())
            {
                File.WriteAllLines(_FileName, jeUserData);
            }
        }
        else
        {
            File.WriteAllLines(_FileName, jeUserData);
        }
    }
}