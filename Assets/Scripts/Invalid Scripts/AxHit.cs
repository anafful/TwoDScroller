using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxHit : MonoBehaviour
{
    public int hitDamage;



    private void OnTriggerEnter(Collider other)
    {
        IDamagable damagable = other.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.TakeDamage(hitDamage);
            gameObject.SetActive(false);
            //OnSnowballAttack?.Invoke();
            Debug.Log("ax Damage");
        }
    }



    //private void OnCollisionEnter(Collision other)
    //{
    //    IDamagable damagable = other.collider.GetComponent<IDamagable>();
    //    if (damagable != null)
    //    {
    //        damagable.TakeDamage(hitDamage);
    //        gameObject.SetActive(false);
    //        Debug.Log("Ax Damage");
    //    }


    //}
}
