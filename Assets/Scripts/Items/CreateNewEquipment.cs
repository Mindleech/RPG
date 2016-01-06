using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Great", "Amazing", "Insane" };
    private string[] itemDes = new string[2] { "A new cool item", "A new not-so-cool item" };

	// Use this for initialization
	void Start () {
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID);
        Debug.Log(newEquipment.EquipmentType.ToString());
        Debug.Log(newEquipment.Strength.ToString());
        Debug.Log(newEquipment.Dexterity.ToString());
        Debug.Log(newEquipment.Intelligence.ToString());
        Debug.Log(newEquipment.SpellEffectID.ToString());
    }
	
    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemType();
        newEquipment.ItemDescription = itemDes[Random.Range(0,itemDes.Length)];
        newEquipment.Strength = Random.Range(1, 101);
        newEquipment.Dexterity = Random.Range(1, 101);
        newEquipment.Intelligence = Random.Range(1, 101);
    }

    private void ChooseItemType()
    {
        int randomTemp = Random.Range(1, 3);
        if(randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ARMOR;
        }
        else if (randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ACCESSORY;
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
