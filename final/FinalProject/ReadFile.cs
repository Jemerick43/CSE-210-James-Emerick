/*
Name: < ReadFile >
Purpose: <  Contains parent methods for Fighter, Wizard, Archer classes
            Baseline for creating and editing new classes.
Author: James Emerick
Date: 
*/
class ReadFile
{
    public static List<string> LoadData(string jeNameForFile)
    {
        List<string> jeData = new();
        if (File.Exists(jeNameForFile))
        {
            string[] jeTempArray = File.ReadAllLines(jeNameForFile);
            foreach (string line in jeTempArray)
            {
                jeData.Add(line); //adds each string from file into a List of Strings
            }
        }
        return jeData;
    }
}