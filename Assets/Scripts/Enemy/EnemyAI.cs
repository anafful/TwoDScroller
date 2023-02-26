
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using static Timer;

public class EnemyAI : MonoBehaviour
{


   
    
    private string currentState = "IdleState";
   
    public Transform target;

    public float attackRange;
    //public int health;

    public Animator animator;

    public static event HandleEnemySnowballAtack OnEnemySnowballAttack;
    public delegate void HandleEnemySnowballAtack();



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
       // health = 10;
    }

    // Update is called once per frame
    void Update()
    {
       

        
        ChangingStates();
      
       

    }
   
     void ChangingStates()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (currentState == "IdleState")
        {
            if (distance < attackRange)
                currentState = "AttackState";
            
            
        }
        else if (currentState == "AttackState")
        {
            //play the run animation

            animator.SetBool("isAttacking", true);
            OnEnemySnowballAttack?.Invoke();

            // Debug.Log("Attack");
        }
        if (currentState == "AttackState")

        {
            if (distance > attackRange)
            {
                currentState = "IdleState";

                animator.SetBool("isAttacking", false);
                animator.SetTrigger("Idle");
            }


        }
    }


   
}
