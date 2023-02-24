using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySnowballAttack : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 10f;
    public Transform spawnPosition;

    public static event HandleEnemySnowballAtack OnEnemySnowballAttack;
    public delegate void HandleEnemySnowballAtack();



    //float fireRate;
    float nextFire;

    public int hitDamage = 2;

   //public static event OnEnemySnowballAtta

    // Start is called before the first frame update
    void Start()
    {
        //fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    void ThrowSnowball()
    {
        if(Time.time > nextFire)
        {
            GameObject ball = Instantiate(projectile, spawnPosition.position, Quaternion.identity);
            ball.GetComponent<Rigidbody>().AddForce(spawnPosition.forward * launchVelocity, ForceMode.Impulse);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        IDamagable damagable = other.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.TakeDamage(hitDamage);
            OnEnemySnowballAttack?.Invoke();
            Debug.Log("Heath reduced");
            // gameObject.SetActive(false);

        }
        //else
        //{
        //    Debug.Log("Heath reduced");

        //}
    }
}
