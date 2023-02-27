using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySnowballAttack : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 10f;
    public Transform spawnPosition;
    public float fireRate;

   // public static EnemySnowballAttack instance;


    //float fireRate;
    float nextFire;

    //public int hitDamage = 2;


    private void Awake()
    {
        //instance = this;    
    }


    // Start is called before the first frame update


    void OnEnable()
    {
        EnemyAI.OnEnemySnowballAttack += ThrowSnowball;
    }

    void OnDisable()
    {
        EnemyAI.OnEnemySnowballAttack -= ThrowSnowball;
    }



    void Start()
    {
       fireRate = 1f;
        nextFire = Time.deltaTime;
    }


   

    void ThrowSnowball()
    {
        if(Time.time > nextFire)
        {
            GameObject ball = Instantiate(projectile, spawnPosition.position, Quaternion.identity);
            //ball.GetComponent<Rigidbody>().AddForce(spawnPosition.forward * launchVelocity, ForceMode.Impulse);
            nextFire = fireRate * Time.deltaTime;
        }
    }


    
}
