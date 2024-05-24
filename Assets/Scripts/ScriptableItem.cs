using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nombre del nuevo item", menuName = "Nombre del menu")]
public class ScriptableItem : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Armor,
        Shield
    }
    
    public ItemType itemType;

    public string itemName;
    public int itemPrice;
    public Sprite itemSprite;
}

