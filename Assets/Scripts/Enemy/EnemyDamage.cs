using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour,IDamagable
{
    public int currentHealth;
    int maxHealth = 100;




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
            //die function
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        //OnSnowballAttack?.Invoke();
    }
}
