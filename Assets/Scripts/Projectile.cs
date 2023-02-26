using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int hitDamage = 2;





    private void OnCollisionEnter(Collision other)
    {
            IDamagable damagable = other.collider.GetComponent<IDamagable>();  
        if(damagable != null)
        {
            damagable.TakeDamage(hitDamage);
            gameObject.SetActive(false);
            Debug.Log("Snowball Damage");
        }
    }
}
