using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer
{

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int health;
    private int mana;
    private int strength;
    private int intelligence;
    private int dexterity;
    private int currentXP;
    private int requiredXP;

   // public string PlayerName
   // {
   //     get { return playerName; }
   //     set { playerName = value; }
   // }

    public string PlayerName { get; set; }
    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }






}
