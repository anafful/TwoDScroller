using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpecimensBroadcasters : MonoBehaviour, ICollectible
{

    public static event HandleSpecimenCollected OnSpecimenCollected;
    public delegate void HandleSpecimenCollected(ItemDataSO itemData);
    public ItemDataSO specimenData;

   

    //public ShopItemSO shopData;


    public void Collect()
    {

       OnSpecimenCollected?.Invoke(specimenData);
        //InventoryManagerListener.Instance.AddItem(specimenData);
        
        Destroy(gameObject);
        Debug.Log("YOU COLLECTED A SPECIMEN");
    }

    public void OpenShop()
    {
    }

    public void Buy()
    {
        //OnBuy?.Invoke(shopData);
        Debug.Log("You bought item");
    }


    public void Sell()
    {
       // OnSell?.Invoke(shopData);
        Debug.Log("You sold item");
    }

}
 