using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public static event HandleHealthPickup OnAddHealth;
    public delegate void HandleHealthPickup();

    public int healthPickup = 1;


    private void OnTriggerEnter(Collider other)
    {
        IAddHealth addHealth = other.GetComponent<IAddHealth>();
        if (addHealth != null)
        {
            addHealth.AddHealth(healthPickup);
            OnAddHealth?.Invoke();

            gameObject.SetActive(false);
            Debug.Log("Add health");
        }

    }
}
