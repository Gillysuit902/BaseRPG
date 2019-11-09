using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogueClass : BaseCharacterClass
{
    public BaseRogueClass()
    {
        CharacterClassName = "Rogue";
        CharacterClassDescription = "Quietly they strike";
        Health = 12;
        Mana = 0;
        Strength = 10;
        Dexterity = 15;
        Intelligence = 8; //45 stat pts total
    }
}
