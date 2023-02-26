using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public static event HandleSnowballAtack OnSnowballAttack;
    public delegate void HandleSnowballAtack();

    public int hitDamage = 2;


    private void OnTriggerEnter(Collider other)
    {
        IDamagable damagable = other.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.TakeDamage(hitDamage);
            OnSnowballAttack?.Invoke();

           // gameObject.SetActive(false);
            Debug.Log("Heath reduced");
        }




        //private void OnCollisionEnter(Collision other)
        //{
        //    IDamagable damagable = other.collider.GetComponent<IDamagable>();
        //    if (damagable != null)
        //    {
        //        damagable.TakeDamage(hitDamage);
        //        gameObject.SetActive(false);
        //        OnSnowballAttack?.Invoke();
        //        Debug.Log("Snowball Damage");
        //    }

        //}
    }
}


//private void OnTriggerEnter(Collider other)
//{
//    IDamagable damagable = other.GetComponent<IDamagable>();  //other.gameObject.CompareTag("Enemy"); 
//    if (damagable != null)
//    {
//        damagable.TakeDamage(hitDamage);
//        OnSnowballAttack?.Invoke();

//        //gameObject.SetActive(false);
//        //Debug.Log("Heath reduced");
//    }

//    else
//    {
//        Debug.Log("Heath reduced");

//    }
//}