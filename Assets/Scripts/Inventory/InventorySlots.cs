using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class InventorySlots : MonoBehaviour
{
   
    public Image icon;
    public TextMeshProUGUI labelName;
    public TextMeshProUGUI stackSizeText;
    //public static InventorySlot instance;
   
    
    

    public void ClearSlot()
    {
        icon.enabled = false;
        labelName.enabled = false;
        stackSizeText.enabled = false;  
    }

    public void DrawSlot(InventoryItem item)
    {
        if (item == null)
        {
            ClearSlot();
            return;
        }


        icon.enabled = true;
        labelName.enabled = true;
        stackSizeText.enabled = true;

        icon.sprite = item.itemData.icon;
        labelName.text = item.itemData.displayName;
        stackSizeText.text = item.stackSize.ToString();

        Debug.Log("UI WORKING");

       
    }

   



}
