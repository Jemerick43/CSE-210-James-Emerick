class Archer : Combat
{
    public override List<string> DoTurnOrder(string jePlayer, List<string> jeEnemies, string jeAttribute)
    {
        jeAttribute = "Dexterity";
        return base.DoTurnOrder(jePlayer, jeEnemies, jeAttribute);
    }
}