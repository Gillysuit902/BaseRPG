using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharm : BaseItem
{
    public enum CharmTypes
    {
        HEALTH,
        MANA,
        STRENGTH,
        INTELLIGENCE,
        DEXTERITY,
        SPELLEFFECT,
        SPEED
    }

    private CharmTypes charmType;
    private int spellEffectID;

    public CharmTypes CharmType
    {
        get { return charmType; }
        set { charmType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
