using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour,IDamagable
{
    public int currentHealth;
    int maxHealth = 4;
    


    //public GameObject destroyEffect;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }


    public void Hit(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {

            Destroy(gameObject);
            Debug.Log("Taking Damage");
            //Instantiate(destroyEffect,transform.position,Quaternion.identity );
            //die function
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        //OnSnowballAttack?.Invoke();
    }
}
