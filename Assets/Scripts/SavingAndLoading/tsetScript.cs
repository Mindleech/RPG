using UnityEngine;
using System.Collections;

public class tsetScript : MonoBehaviour {

	void Start()
    {
        LoadInformation.LoadAllInformation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        //Debug.Log("Player Class: " + GameInformation.PlayerClass.CharacterClassName)
        Debug.Log("Player Level " + GameInformation.PlayerLevel);
        Debug.Log("Player Strength " + GameInformation.PlayerStrength);
        Debug.Log("Player Dexterity " + GameInformation.PlayerDexterity);
        Debug.Log("Player Intelligence " + GameInformation.PlayerIntelligence);
    }

    void update()
    {

    }
}
