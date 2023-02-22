using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedItem : MonoBehaviour
{
    private ItemDataSO itemData; // the item data for the dropped item

    public void SetItemData(ItemDataSO itemData)
    {
        this.itemData = itemData;
    }
}
