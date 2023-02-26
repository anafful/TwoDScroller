using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThrowAttack : MonoBehaviour
{


    public GameObject projectile;
    public float launchVelocity = 10f;
    public Transform spawnPosition;
    public Animator anim;

    // public static event HandleSnowballAtack OnSnowballAttack;
    //public delegate void HandleSnowballAtack();

    //public int hitDamage = 2;
    private void Start()
    {
       // anim.SetBool("Throw", false);
    }

    void Update()
    {
        // need to check if theres any snowballs in the inventory

        if (Input.GetMouseButtonDown(0))
        {
            GameObject snowball = SnowballObjectPool.instance.GetPooledObjects();


            if (snowball != null)
            {
                snowball.transform.position = spawnPosition.position;
                snowball.SetActive(true);
            }
            //GameObject snowball = Instantiate(projectile, spawnPosition.position, transform.rotation);
            snowball.GetComponent<Rigidbody>().AddForce(spawnPosition.forward * launchVelocity, ForceMode.Impulse);



            //transform.position += launchVelocity * Time.deltaTime * transform.forward;
            anim.SetBool("Throw", true);
            Debug.Log("Throw Snowball");

        }
        else
        {
            anim.SetBool("Throw", false);
        }
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //   IDamagable damagable = other.GetComponent<IDamagable>();
    //    if(damagable != null)
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
    }


  

  

