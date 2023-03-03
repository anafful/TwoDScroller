using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryListener : MonoBehaviour

    // THIS HANDLING THE STACKS ADDING AND REMOVING 
{
    public static event Action<List<InventoryItem>> OnInventoryChange;

    public List<InventoryItem> inventory = new List<InventoryItem>();// list 
    private Dictionary<ItemDataSO, InventoryItem> itemDictionary = new Dictionary<ItemDataSO, InventoryItem>(); // handling stacking values


    //public GameObject droppedItemPrefab;

    private void OnEnable()
    {
        SpecimensBroadcasters.OnSpecimenCollected += add;
        FishBroadcasters.OnFishCollected += add;
        PickAxBroadcasters.OnPickAxCollected += add;
        SnowballBroadcasters.OnSnowballCollected += add;
    }

    private void OnDisable()
    {
        SpecimensBroadcasters.OnSpecimenCollected -= add;
        FishBroadcasters.OnFishCollected -= add;    
        PickAxBroadcasters.OnPickAxCollected -= add;  
        SnowballBroadcasters.OnSnowballCollected -= add;

    }

    public void add(ItemDataSO itemData)// add and removes the stack size
        {

        if(itemDictionary.TryGetValue(itemData, out InventoryItem item)) //checking the item is thelist 
        {
            item.AddToStack(); // increase the stack list
            Debug.Log($" {item.itemData.displayName} total stack is now { item.stackSize}");
            OnInventoryChange?.Invoke(inventory); Debug.Log(OnInventoryChange);
        }

        else
        {
            InventoryItem newItem = new InventoryItem(itemData); ///if item is not in list then add new one to the list
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($" Added {itemData.displayName} to the inventory for the first time.");
            OnInventoryChange?.Invoke(inventory);
        }


        }

    public void Remove(ItemDataSO itemData)
    {
        if (itemDictionary.TryGetValue(itemData, out InventoryItem item)) //checking the item is thelist 
        {
            item.RemoveFromStack(); // decrease the stack list

            if(item.stackSize == 0)// if its stack is zero remove from list and and dictionary
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
               
            }

           
            
            OnInventoryChange?.Invoke(inventory);
        }
    }


    //public void RemoveAndRespawn(ItemDataSO itemData, Vector3 position)
    //{
    //    if (itemDictionary.TryGetValue(itemData, out InventoryItem item)) //checking the item is in the list 
    //    {
    //        item.RemoveFromStack(); // decrease the stack list

    //        if (item.stackSize == 0)// if its stack is zero remove from list and dictionary
    //        {
    //            inventory.Remove(item);
    //            itemDictionary.Remove(itemData);

    //            // Instantiate the dropped item prefab at the specified position
    //            GameObject droppedItemGO = Instantiate(droppedItemPrefab, position, Quaternion.identity);

    //            // Set the item data for the dropped item
    //            DroppedItem droppedItem = droppedItemGO.GetComponent<DroppedItem>();
    //            droppedItem.SetItemData(itemData);
    //        }

    //        OnInventoryChange?.Invoke(inventory);
    //    }

    //}

   }