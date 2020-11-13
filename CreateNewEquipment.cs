using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour
{

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] {"Common", "Rare", "Unique", "Ancient" };
    private string[] itemDescription = new string[2] { "This is a piece of equipment Mjo", "This item sucks Mjo" };

        void Start()
        {
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log(newEquipment.EquipmentType.ToString());
        Debug.Log(newEquipment.Health.ToString());
        Debug.Log(newEquipment.Mana.ToString());
        Debug.Log(newEquipment.Strength.ToString());
        Debug.Log(newEquipment.Intelligence.ToString());
        Debug.Log(newEquipment.Dexterity.ToString());
        }

    public void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemType();
        newEquipment.ItemDescription = itemDescription[Random.Range(0, itemDescription.Length)];
        //Stats
        newEquipment.Health = Random.Range(0, 10);
        newEquipment.Mana = Random.Range(0, 10);
        newEquipment.Strength = Random.Range(0, 10);
        newEquipment.Intelligence = Random.Range(0, 10);
        newEquipment.Dexterity = Random.Range(0, 10);
        //Assing Spell Effect ID
        newEquipment.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseItemType()
    {
        int randomTemp = Random.Range(1, 8);
        if(randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.AMULET;
        }
        else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BELT;
        }
        else if(randomTemp == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BOOTS;
        }
        else if(randomTemp == 4)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
        }
        else if(randomTemp == 5)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.GLOVES;
        }
        else if(randomTemp == 6)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
        }
        else if(randomTemp == 7)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
        }
        else if(randomTemp == 8)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
        }
    }

    void Update()
    {
        
    }
}
