using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation
{

    public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Health = PlayerPrefs.GetInt("HEALTH");
        GameInformation.Mana = PlayerPrefs.GetInt("MANA");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInformation.Intelligence = PlayerPrefs.GetInt("INTELLIGENCE");
        GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");

        if(PlayerPrefs.GetString("EQUIPMENTITEM1") != null)
        {
            GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENTITEM1");
        }
    }


}





