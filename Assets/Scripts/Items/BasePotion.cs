using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

	public enum PotionTypes
    {
        STRENGTH,
        INTELLIGENCE,
        DEXTERITY
    }

    private PotionTypes potionType;
    private int spellEffectID;

    public PotionTypes PotionType { get; set; }
    public int SpellEffectID { get; set; }
}
