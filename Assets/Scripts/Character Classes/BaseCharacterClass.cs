using UnityEngine;
using System.Collections;

public class BaseCharacterClass : MonoBehaviour {

    private string characterClassName;
    private string characterClassDescription;
    //Attributes
    public int strength;
    public int dexterity;
    public int intelligence;

    public string CharacterClassName { get; set; }
    public string CharacterClassDescription { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
}
