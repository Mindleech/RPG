using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID);
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Strength.ToString());
        Debug.Log(newWeapon.Dexterity.ToString());
        Debug.Log(newWeapon.Intelligence.ToString());
        Debug.Log(newWeapon.SpellEffectID.ToString());

    }

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();
        //assign name to the weapon
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //create a weapon description
        newWeapon.ItemDescription = "This is a new Weapon";
        //weapon ID
        newWeapon.ItemID = Random.Range(1,101);
        //stats
        newWeapon.Strength = Random.Range(1, 101);
        newWeapon.Dexterity = Random.Range(1, 101);
        newWeapon.Intelligence = Random.Range(1, 101);
        //choose type of weapon
        ChooseWeaponType();
        //spell effect ID
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 7);
        if (randomTemp == 1){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }else if (randomTemp == 2){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        }else if (randomTemp == 3){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }else if (randomTemp == 4){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
        }else if (randomTemp == 5){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
        }else if (randomTemp == 6){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
        }
    }
}
