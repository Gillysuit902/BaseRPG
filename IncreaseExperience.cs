using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience 
{
    private static int xpToGive;

    public static void AddExperience()
    {
        xpToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentXP += xpToGive;
        CheckToSeeIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    private static void CheckToSeeIfPlayerLeveled()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            //player has leveled up
            //create level up script
        }
    }
}
