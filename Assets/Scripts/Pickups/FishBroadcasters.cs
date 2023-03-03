using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class FishBroadcasters : MonoBehaviour, ICollectible
{

    public static event HandleFishCollected OnFishCollected;  //instance of the delegat

    public delegate void HandleFishCollected(ItemDataSO itemData); // define delegate

   

    public ItemDataSO fishData;
   

    public void Collect()
    {

        OnFishCollected?.Invoke(fishData);
       
        //InventoryManagerListener.Instance.AddItem(fishData);
        Destroy(gameObject);
        Debug.Log("YOU COLLECTED A FISH");
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
        //OnSell?.Invoke(shopData);
        Debug.Log("You sold item");
    }

    }
