/*
Name: < Combat >
Purpose: <  Contains methods for all battle behavior (ie attack rolls, saving throws, etc)
Author: James Emerick
Date: 
*/

class Combat
{
    private string _defaultString;
    private Random _Roll = new();
    private int _RollScore;
    private List<int> _Initiative = new();
    private List<string> _Foes = new();
    private bool _Running = true;
    private int _BaseInt;
    private int _Damage;
    public int DetermineAttribute(string jeAttribute)
    {
        if (jeAttribute == "HP")
        {
            _BaseInt = 6;
        }
        else
        {
            if (jeAttribute == "Strength")
            {
                _BaseInt = 0;
            }
            else if (jeAttribute == "Dexterity")
            {
                _BaseInt = 1;
            }
            else if (jeAttribute == "Constitution")
            {
                _BaseInt = 2;
            }
            else if (jeAttribute == "Inteligence")
            {
                _BaseInt = 3;
            }
            else if (jeAttribute == "Wisdom")
            {
                _BaseInt = 4;
            }
            else if (jeAttribute == "Charisma")
            {
                _BaseInt = 5;
            }
        }

        return _BaseInt;
    }
    public int DetermineModifier(string jePlayer, string jeAttribute)
    {
        int jeModifier = 10;
        _BaseInt = DetermineAttribute(jeAttribute);

        string[] jeTempStrings = jePlayer.Split(':');
        jeTempStrings = jeTempStrings[1].Split(',');
        //Below determines which attribute to select and how to define the roll bonus , , , and , and Current Hp
        if (int.Parse(jeTempStrings[_BaseInt]) <= 6)
        {
            jeModifier = -2;
        }
        else if (int.Parse(jeTempStrings[_BaseInt]) <= 8)
        {
            jeModifier = -1;
        }
        else if (int.Parse(jeTempStrings[_BaseInt]) <= 10)
        {
            jeModifier = 0;
        }
        else if (int.Parse(jeTempStrings[_BaseInt]) <= 12)
        {
            jeModifier = 1;
        }
        else if (int.Parse(jeTempStrings[_BaseInt]) <= 14)
        {
            jeModifier = 2;
        }
        else if (int.Parse(jeTempStrings[_BaseInt]) <= 16)
        {
            jeModifier = 3;
        }
        else if (int.Parse(jeTempStrings[_BaseInt]) <= 18)
        {
            jeModifier = 4;
        }
        return jeModifier;
    }
    public virtual List<string> DoTurnOrder(string jePlayer, List<String> jeEnemies, string jeAttribute)
    {
        Console.WriteLine("What would you like to do? \n\t 1. Fight!\n\t 2. Flee!!\n");
        _BaseInt = int.Parse(Console.ReadLine());
        if (_BaseInt == 1)
        {
            Console.WriteLine("Please select an enemy to attack: ");
            int i = 0;
            foreach (string jeEnemy in jeEnemies)
            {
                i++;
                string[] tempEnemy = jeEnemy.Split(";");
                Console.WriteLine("\n\t {0}. {1}", i, tempEnemy[0]);
            }
            i = int.Parse(Console.ReadLine());
            string[] jeTempEnemy = jeEnemies[i - 1].Split(':');
            Console.WriteLine("You attack the {0}", jeTempEnemy[0]);
            _Damage = _Roll.Next(1, 20) + DetermineModifier(jePlayer, jeAttribute);
            Console.WriteLine("You roll a(n) {0}...", _Damage);
            string[] jeTempEnemy2 = jeTempEnemy[1].Split(',');
            {
                Console.WriteLine("You deal {0} damage to the {1}!", DetermineModifier(jePlayer, jeAttribute), jeTempEnemy[0]);
                _BaseInt = int.Parse(jeTempEnemy2[6]) - DetermineModifier(jePlayer, jeAttribute);
                jeTempEnemy2[6] = _BaseInt.ToString();
                jeTempEnemy2[0] = ';' + jeTempEnemy2[0];
                jeTempEnemy[1] = String.Join(",", jeTempEnemy2);
                jeEnemies[i - 1] = jeTempEnemy.ToString();
                return jeEnemies;
            }
            else
            {
                Console.WriteLine("Your attack Missed!");
            }
        }
        else
        {
            Console.WriteLine("You try to escape combat...");
        }
        return jeEnemies;
    }
    public int CalculateHP(List<string> jeEntities)
    {
        _BaseInt = 0;
        foreach (string jeMob in jeEntities)
        {
            string[] jeTemp = jeMob.Split(":");
            jeTemp = jeTemp[1].Split(',');
            _BaseInt += int.Parse(jeTemp[6]);
        }
        return _BaseInt;
    }

    public List<string> RunCombatLoop(List<string> jeParty)
    {
        Display jePromptUser = new();
        _Foes = ReadFile.LoadData("enemies.txt");
        Console.WriteLine("Entering Combat!! The party of {0} encounters {1} enemies!", jeParty.Count, _Foes.Count);
        foreach (string jePlayer in jeParty) //runs initiative for party members
        {
            string[] jeTempPlayer = jePlayer.Split(";");
            _RollScore = _Roll.Next(1, 20) + DetermineModifier(jePlayer, "Dexterity");
            Console.WriteLine("{0} rolled a {1}!", jeTempPlayer[0], _RollScore);
            _Initiative.Add(_RollScore);
            Console.WriteLine("Roll added to initiative.");
        }
        foreach (string jeEnemy in _Foes) //runs initiative for each enemy
        {
            string[] jeTempMob = jeEnemy.Split(";");
            _RollScore = _Roll.Next(1, 20) + DetermineModifier(jeEnemy, "Dexterity");
            Console.WriteLine("{0} rolled a {1}!", jeTempMob[0], _RollScore);
            _Initiative.Add(_RollScore);
            Console.WriteLine("Roll added to initiative.");
        }
        int jeTempIterate = 0;
        List<KeyValuePair<string, int>> jeInitiativeMap = new();
        int i = 0;
        foreach (int jeMobScore in _Initiative) //organizes turn order by number value of rollscore
        {
            if (i + 1 <= jeParty.Count)
            {
                jeInitiativeMap.Add(new KeyValuePair<string, int>(jeParty[i], _Initiative[i]));
                i++;
            }
            else
            {
                jeInitiativeMap.Add(new KeyValuePair<string, int>(_Foes[jeTempIterate], _Initiative[i]));
                i++;
                jeTempIterate++;
            }
        }
        var jeSortedList = jeInitiativeMap.OrderByDescending(x => x.Value);
        while (_Running)
        {
            foreach (var item in jeSortedList)
            {
                if (!item.ToString().Contains("Vs;"))
                {
                    string jePlayer = item.ToString();
                    string[] jeTempPlayer = jePlayer.Split(":");
                    jeTempPlayer = jeTempPlayer[0].Split(';'); //Gets character name and class
                    if (jeTempPlayer[1] == "Fighter")
                    {
                        Console.WriteLine("It is {0}'s turn!", jeTempPlayer[0]);
                        _Foes = DoTurnOrder(item.ToString(), _Foes, "Strength");
                    }
                    else if (jeTempPlayer[1] == "Wizard")
                    {
                        Console.WriteLine("It is {0}'s turn!", jeTempPlayer[0]);
                        Wizard jeTempWizard = new();
                        _Foes = jeTempWizard.DoTurnOrder(item.ToString(), _Foes, _defaultString);
                    }
                    else if (jeTempPlayer[1] == "Archer")
                    {
                        Console.WriteLine("It is {0}'s turn!", jeTempPlayer[0]);
                        Archer jeTempArcher = new();
                        _Foes = jeTempArcher.DoTurnOrder(item.ToString(), _Foes, _defaultString);
                    }
                }
                else
                {
                    string jePlayer = item.ToString();
                    string[] jeTempPlayer = jePlayer.Split(":");
                    jeTempPlayer = jeTempPlayer[0].Split(';');
                    Console.WriteLine("It is {0}'s turn!", jeTempPlayer[0]);
                    _Damage = _Roll.Next(1, 20) + DetermineModifier(item.Key, "Strength");
                    i = _Roll.Next(0, jeParty.Count - 1);
                    jeTempPlayer = jeParty[i].Split(':');
                    _defaultString = jeTempPlayer[0];
                    jeTempPlayer = jeTempPlayer[1].Split(',');
                    if (int.Parse(jeTempPlayer[6]) < _Damage)
                    {
                        int dmg = DetermineModifier(item.Key, "Strength");
                        jeTempPlayer[6] = (int.Parse(jeTempPlayer[6]) - dmg).ToString();
                        Console.WriteLine("{0} received {} damage!!", _defaultString, dmg);
                        if (jeTempPlayer[6] == "0")
                        {
                            Console.WriteLine("{0} has run out of HP!", _defaultString);
                        }
                    }
                }

            }
            if (CalculateHP(jeParty) == 0)
            {
                Console.WriteLine("Your party has run out of HP!! You lose the battle!");
                _Running = false;
            }
            else if (CalculateHP(_Foes) == 0)
            {
                Console.WriteLine("The enemies have run out of HP!! You won the battle!");
                _Running = false;
            }
        }
        return jeParty;
    }

}