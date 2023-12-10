
class Wizard : Combat
{
    public override List<string> DoTurnOrder(string jePlayer, List<string> jeEnemies, string jeAttribute)
    {
        jeAttribute = "Wisdom";
        return base.DoTurnOrder(jePlayer, jeEnemies, jeAttribute);
    }
}