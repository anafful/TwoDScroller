using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopItem", menuName = "Shop/ShopItem")]
public class ShopItemSO : ScriptableObject
{
    public String itemName;
    public int itemPrice;
    public int itemQuautity;
}
