using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();
        if(collectible != null)
        {
            collectible.Collect();
            Debug.Log("Collect item");
        }

    }
}
