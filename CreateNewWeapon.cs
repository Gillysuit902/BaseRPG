using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon newWeapon;

    //void Start()
    //{
      //CreateWeapon();
      //Debug.Log(newWeapon.ItemName);
      //Debug.Log(newWeapon.ItemDescription);
      //Debug.Log(newWeapon.ItemID.ToString());
      //Debug.Log(newWeapon.WeaponType.ToString());
      //Debug.Log(newWeapon.Health.ToString());
      //Debug.Log(newWeapon.Mana.ToString());
      //Debug.Log(newWeapon.Strength.ToString());
      //Debug.Log(newWeapon.Intelligence.ToString());
      //Debug.Log(newWeapon.Dexterity.ToString());
    //}

    public void CreateWeapon()
    {
        
        newWeapon = new BaseWeapon();
        //Name the Weapon
        newWeapon.ItemName = "Weapon" + Random.Range(1, 101);
        //Weapon description
        newWeapon.ItemDescription = "This is a weapon mjo";
        //Assign Weapon ID
        newWeapon.ItemID = Random.Range(1, 101);
        //Stats
        newWeapon.Health = Random.Range(0, 10);
        newWeapon.Mana = Random.Range(0, 10);
        newWeapon.Strength = Random.Range(0, 10);
        newWeapon.Intelligence = Random.Range(0, 10);
        newWeapon.Dexterity = Random.Range(0, 10);
        //Choose Weapon Type
        ChooseWeaponType();
        //Assing Spell Effect ID
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 6);
        if (randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }
        else if(randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.WAND;
        }
        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
        }
        else if (randomTemp == 6)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }
    }
}
