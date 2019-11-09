using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharm : MonoBehaviour
{

    private BaseCharm newCharm;

    // Start is called before the first frame update
    void Start()
    {
        CreateCharm();
        Debug.Log(newCharm.ItemName);
        Debug.Log(newCharm.ItemDescription);
        Debug.Log(newCharm.ItemID.ToString());
        Debug.Log(newCharm.SpellEffectID.ToString());
    }


    private void CreateCharm()
    {
        newCharm = new BaseCharm();
        newCharm.ItemName = "Charm";
        newCharm.ItemDescription = "Charms provide passives";
        newCharm.ItemID = Random.Range(1, 101);
        newCharm.SpellEffectID = Random.Range(500, 1000);
    }
}
