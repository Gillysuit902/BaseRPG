using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{

    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("HEALTH", GameInformation.Health);
        PlayerPrefs.SetInt("MANA", GameInformation.Mana);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("INTELLIGENCE", GameInformation.Intelligence);
        PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);


        if(GameInformation.EquipmentOne != null)
        {

        PPSerialization.Save("EQUIPMENTITEM1", GameInformation.EquipmentOne);
        }
        Debug.Log("SAVED ALL INFORMATION");

    }




}
