using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class FishBroadcasters : MonoBehaviour, ICollectible
{

    public static event HandleFishCollected OnFishCollected;  //instance of the delegat

    public delegate void HandleFishCollected(ItemDataSO itemData); // define delegate

    //public delegate void HandleBuy(ShopItemSO shopData);
    //public static event HandleBuy OnBuy;

    //public delegate void HandleSell(ShopItemSO shopData);
    //public static event HandleSell OnSell;


    public ItemDataSO fishData;
    //public ShopItemSO shopData;


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
