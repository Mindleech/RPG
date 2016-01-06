using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

    private BasePotion newPotion;
    //string that has sevreal names for potions

	// Use this for initialization
	void Start () {
        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID);
        Debug.Log(newPotion.PotionType.ToString());
        Debug.Log(newPotion.SpellEffectID.ToString());
    }
	
    private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "This is a potion.";
        newPotion.ItemID = Random.Range(1,101);
        ChoosePotionType();
        newPotion.SpellEffectID = Random.Range(1,101);

    }

	private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, 3);
        if(randomTemp == 0)
        {
            newPotion.PotionType = BasePotion.PotionTypes.DEXTERITY;
        }
        else if (randomTemp == 1)
        {
            newPotion.PotionType = BasePotion.PotionTypes.INTELLIGENCE;
        }
        else if (randomTemp == 2)
        {
            newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
        }
    }
}
