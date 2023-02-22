using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System; 

public class InventoryItem
// Start is called before the first frame update
{
    public ItemDataSO itemData;
    public int stackSize;

    //public static InventoryItem Instance;


    void Awake()
    {
       // Instance = this;
    }

    public InventoryItem(ItemDataSO item)
    {
        itemData = item;
        AddToStack();
    }


    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }
}


