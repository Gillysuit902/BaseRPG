using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseWarriorClass();
    private BaseCharacterClass class2 = new BaseMageClass();
    private BaseCharacterClass class3 = new BaseRogueClass();
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class1.Strength.ToString());
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class2.Intelligence.ToString());
        GUILayout.Label(class3.CharacterClassName);
        GUILayout.Label(class3.CharacterClassDescription);
        GUILayout.Label(class3.Dexterity.ToString());
    }
}
