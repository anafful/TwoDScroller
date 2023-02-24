using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersDamage : MonoBehaviour, IDamagable
{

    public int health;


   

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {

            Destroy(gameObject);
            //die function
        }
    }

    public void TakeDamage(int damageAmount)
    {
        Hit(damageAmount);
        //OnSnowballAttack?.Invoke();
    }

}
