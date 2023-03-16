using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThrowAttack : MonoBehaviour
{


    public GameObject projectile;
    public float launchVelocity = 10f;
    public Transform spawnPosition;
    public Animator anim;

    float throwForce;



    //public int hitDamage = 2;
    private void Start()
    {
       
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
               // snowball.transform.Translate(Vector3.forward * throwForce);
                
                snowball.SetActive(true);

                Physics.IgnoreCollision(snowball.GetComponent<Collider>(), GetComponent<Collider>());


                snowball.transform.Translate(spawnPosition.forward * throwForce * Time.deltaTime, Space.World);


            }
            //GameObject snowball = Instantiate(projectile, spawnPosition.position, transform.rotation);
            // snowball.GetComponent<Rigidbody>().AddForce(spawnPosition.forward * launchVelocity, ForceMode.Impulse);




            //transform.position += launchVelocity * Time.deltaTime * transform.forward;
            anim.SetBool("Throw", true);
            Debug.Log("Throw Snowball");

        }
        else
        {
            anim.SetBool("Throw", false);
        }
        
    }

    
    }


  

  

