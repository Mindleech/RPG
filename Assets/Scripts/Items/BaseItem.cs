﻿using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {

    private string itemName;
    private string itemDescription;
    private int itemID;
    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        CHEST
    }
    private ItemTypes itemType;

    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public ItemTypes ItemType { get; set; }
}