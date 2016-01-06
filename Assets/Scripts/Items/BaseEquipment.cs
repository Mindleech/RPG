using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes
    {
        ARMOR,
        ACCESSORY
    }
    private EquipmentTypes equipmentType;
    private int spellEffectID;

    public EquipmentTypes EquipmentType { get; set; }
    public int SpellEffectID { get; set; }
}
