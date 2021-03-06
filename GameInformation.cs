﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static BaseEquipment EquipmentOne { get; set; }
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Health { get; set; }
    public static int Mana { get; set; }
    public static int Strength { get; set; }
    public static int Intelligence { get; set; }
    public static int Dexterity { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }

}
