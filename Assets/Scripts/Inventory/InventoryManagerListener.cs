using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoryManagerListener : MonoBehaviour
{
    public GameObject slotPrefab;
    public static InventoryManagerListener Instance;

    //public Transform itemContent;
    

    //public List<ItemDataSO> inventoryItems = new List<ItemDataSO>();
    public List<InventorySlots> inventorySlots = new List<InventorySlots>(5);  

    private void Awake()
    {
        Instance = this;
    }


    private void OnEnable()
    {
        InventoryListener.OnInventoryChange += DrawInventory;
    }

    private void OnDisable()
    {
        InventoryListener.OnInventoryChange -= DrawInventory;
    }

    void ResetInventory()
    {
        foreach (Transform childTransfrom in transform)
        {
            Destroy(childTransfrom.gameObject);
        }

        inventorySlots = new List<InventorySlots>(5);
    }



  


    void DrawInventory(List<InventoryItem> inventory)
    {

        ResetInventory(); // clear panel

        for(int i = 0; i <inventorySlots.Capacity; i++)
        {
        CreateInventorySlot(); //create slots

            Debug.Log("Create slot");

            Debug.Log(inventory);
        }

        for (int i = 0; i < inventory.Count; i++)
        {
            
            inventorySlots[i].DrawSlot(inventory[i]); // update each slot occordingly 
        }

        
    }

    public void CreateInventorySlot()
    {
            GameObject newSlot = Instantiate(slotPrefab);
             newSlot.transform.SetParent(transform, false);

            InventorySlots newSlotComponent = newSlot.GetComponent<InventorySlots>();
            newSlotComponent.ClearSlot();
            inventorySlots.Add(newSlotComponent);

        

        }
    }


