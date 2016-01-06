using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A strong and powerfull hero.";
        Strength = 10;
        Dexterity = 7;
        Intelligence = 3;
    }
}
