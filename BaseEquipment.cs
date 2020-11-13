using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEquipment : BaseStatItem
{
    public enum EquipmentTypes
    {
        HEAD,
        CHEST,
        SHOULDERS,
        GLOVES,
        BELT,
        AMULET,
        RING,
        BOOTS
    }
    private EquipmentTypes equipmentType;
    private int spellEffectID;

    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}

