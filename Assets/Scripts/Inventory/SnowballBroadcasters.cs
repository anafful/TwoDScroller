using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballBroadcasters : MonoBehaviour, ICollectible
{
    public static event HandleSnowballCollected OnSnowballCollected;  //instance of the delegat

    public delegate void HandleSnowballCollected(ItemDataSO itemData); // define delegate



    public ItemDataSO SnowballData;
    //public ShopItemSO shopData;


    public void Collect()
    {

        OnSnowballCollected?.Invoke(SnowballData);
        //InventoryManagerListener.Instance.AddItem(fishData);
        Destroy(gameObject);
        Debug.Log("YOU COLLECTED pickax");
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

