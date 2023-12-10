/*
Name: < Foes >
Purpose: <  Contains methods for all enemy behavior (ie setting and retrieving enemy statistics)
Author: James Emerick
Date: 
*/

class Foes : CharacterClass
{
    private string _creatureType;
    public Foes() : base()
    {

    }
    public override string GetClass()
    {
        Console.WriteLine("Please enter the name of your creature: ");
        _creatureType = Console.ReadLine() + ";";
        return _creatureType;
    }
    public override string GetStatistics(string jeCharacter)
    {
        return base.GetStatistics(jeCharacter);
    }
    public void StoreEnemies(List<string> jeEnemies)
    {
        WriteFile jeTempWrite = new();
        jeTempWrite.SaveData(jeEnemies, "enemies.txt");
    }
    public override List<string> EditCharacter(List<string> jeCharacters)
    {
        return base.EditCharacter(jeCharacters);
    }
}