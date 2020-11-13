using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadInformation.LoadAllInformation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        //Debug.Log("Player Class: " + GameInformation.PlayerClass);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Health: " + GameInformation.Health);
        Debug.Log("Player Mana: " + GameInformation.Mana);
        Debug.Log("Player Strength: " + GameInformation.Strength);
        Debug.Log("Player Intelligence: " + GameInformation.Intelligence);
        Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
