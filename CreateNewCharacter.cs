using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    private bool isRogueClass;
    private string playerName = "Enter Name" ;

    // Start is called before the first frame update
    void Start()
    {
        newPlayer = new BasePlayer(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue Class");
        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            else if (isRogueClass)
            {
                newPlayer.PlayerClass = new BaseRogueClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.Health = newPlayer.PlayerClass.Health;
            newPlayer.Mana = newPlayer.PlayerClass.Mana;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
            newPlayer.PlayerName = playerName;
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("Player Name:" + newPlayer.PlayerName);
            Debug.Log("Player Class:" + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Level:" + newPlayer.PlayerLevel);
            Debug.Log("Player Health:" + newPlayer.Health);
            Debug.Log("Player Mana:" + newPlayer.Mana);
            Debug.Log("Player Strength:" + newPlayer.Strength);
            Debug.Log("Player Intelligence:" + newPlayer.Intelligence);
            Debug.Log("Player Dexterity:" + newPlayer.Dexterity);
        }
        if (GUILayout.Button("Load"))
        {
            SceneManager.LoadScene ("tset");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Health = newPlayer.Health;
        GameInformation.Mana = newPlayer.Mana;
        GameInformation.Strength = newPlayer.Strength;
        GameInformation.Intelligence = newPlayer.Intelligence;
        GameInformation.Dexterity = newPlayer.Dexterity;
        
    }
}
