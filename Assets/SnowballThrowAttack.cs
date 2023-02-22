using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThrowAttack : MonoBehaviour
{


    public GameObject projectile;
    public float launchVelocity = 10f;
    public Transform spawnPosition;
    public Animator anim;

    

    public int hitDamage = 2;
    private void Start()
    {
       // anim.SetBool("Throw", false);
    }

    void Update()
    {
        // need to check if theres any snowballs in the inventory

        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(projectile, spawnPosition.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(spawnPosition.forward * launchVelocity, ForceMode.Impulse );

            //transform.position += launchVelocity * Time.deltaTime * transform.forward;
            anim.SetBool("Throw", true);
            //Debug.Log("Hit Enemy");
           
        }
        else
        {
            anim.SetBool("Throw", false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
       IDamagable damagable = other.GetComponent<IDamagable>();
        if(damagable != null)
        {
            damagable.TakeDamage(hitDamage);
            Debug.Log("Heath reduced");
        }
    }


  

  

}
