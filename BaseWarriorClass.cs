using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass
{
    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "True strength lies within";
        Health = 15;
        Mana = 0;
        Strength = 14;
        Dexterity = 10;
        Intelligence = 6; //45 stat pts total
    }

}
