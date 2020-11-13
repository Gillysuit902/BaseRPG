using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacterClass
{
    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "Weilder of the Elder's powers";
        Health = 10;
        Mana = 5;
        Strength = 4;
        Dexterity = 10;
        Intelligence = 16; //45 stat pts total
    }
}
