using UnityEngine;
using System.Collections;

public class CreateNewPlayer : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isScholarClass;
    private bool isWarriorClass;
    public string playerName;

	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);
        isScholarClass = GUILayout.Toggle(isScholarClass, "Scholar Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        if (GUILayout.Button("Create"))
        {
            if (isScholarClass)
            {
                newPlayer.PlayerClass = new BaseScholarClass();

            }else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.PlayerStrength = newPlayer.PlayerClass.Strength;
            newPlayer.PlayerDexterity = newPlayer.PlayerClass.Dexterity;
            newPlayer.PlayerIntelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.PlayerName = playerName;
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();
            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("Player Class" + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Strength: " + newPlayer.PlayerStrength);
            Debug.Log("Player Dexterity: " + newPlayer.PlayerDexterity);
            Debug.Log("Player Intelligence: " + newPlayer.PlayerIntelligence);
        }
        if (GUILayout.Button("Load"))
        {
            Application.LoadLevel("tset");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.PlayerStrength = newPlayer.PlayerStrength;
        GameInformation.PlayerDexterity = newPlayer.PlayerDexterity;
        GameInformation.PlayerIntelligence = newPlayer.PlayerIntelligence;
    }
}
