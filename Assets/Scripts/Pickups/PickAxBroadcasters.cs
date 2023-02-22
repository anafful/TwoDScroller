using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAxBroadcasters : MonoBehaviour, ICollectible
{
    public static event HandlePickAxCollected OnPickAxCollected;  //instance of the delegat

    public delegate void HandlePickAxCollected(ItemDataSO itemData); // define delegate

  
    public ItemDataSO PickAXData;
    //public ShopItemSO shopData;


    public void Collect()
    {

        OnPickAxCollected?.Invoke(PickAXData);
        //InventoryManagerListener.Instance.AddItem(fishData);
        Destroy(gameObject);
        Debug.Log("YOU COLLECTED PICKAX");
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

