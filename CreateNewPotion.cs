using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour
{
    private BasePotion newPotion;

    // Start is called before the first frame update
    void Start()
    {
        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType.ToString());
    }

    private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "This is a potion mjo";
        newPotion.ItemID = Random.Range(0, 101);
        ChoosePotionType();
    }

    private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, 6);
        if(randomTemp == 0)
        {
            newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
        }
        else if(randomTemp == 1)
        {
            newPotion.PotionType = BasePotion.PotionTypes.MANA;
        }
        else if (randomTemp == 2)
        {
            newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
        }
        else if (randomTemp == 3)
        {
            newPotion.PotionType = BasePotion.PotionTypes.INTELLIGENCE;
        }
        else if (randomTemp == 4)
        {
            newPotion.PotionType = BasePotion.PotionTypes.DEXTERITY;
        }
        else if (randomTemp == 5)
        {
            newPotion.PotionType = BasePotion.PotionTypes.SPEED;
        }
        else if (randomTemp == 6)
        {
            newPotion.PotionType = BasePotion.PotionTypes.SPELLEFFECT;
        }
    }
}