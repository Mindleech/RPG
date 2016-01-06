using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.PlayerStrength);
        PlayerPrefs.SetInt("DEXTERITY", GameInformation.PlayerDexterity);
        PlayerPrefs.SetInt("INTELLIGENCE", GameInformation.PlayerIntelligence);

        Debug.Log("Saved ALL Information");
    }
}
