using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersHealth : MonoBehaviour, IDamagable, IAddHealth
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

    public void AddHealth(int addHealthAmount)
    {
        currentHealth += addHealthAmount;
        if(currentHealth == maxHealth)
        {
            return;
        }
    }

}
