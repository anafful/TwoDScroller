using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour,IDamagable
{
    public int health;



  

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

   

    public void Hit(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {

            Destroy(gameObject);
            Debug.Log("Hit by payer");
            //die function
        }
    }

    public void TakeDamage(int damageAmount)
    {
        Hit(damageAmount);
    }

}
