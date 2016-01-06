using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.PlayerStrength = PlayerPrefs.GetInt("STRENGTH");
        GameInformation.PlayerDexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInformation.PlayerIntelligence = PlayerPrefs.GetInt("INTELLIGENCE");
    }
}
