using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformsRL : MonoBehaviour
{

    public float speed = 2f;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject ==  player)
        {
            player.transform.parent = transform;    
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            player.transform.parent = null;
        }
    }

    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(startPosition.x +5, startPosition.y, startPosition.z);
    }


    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time * speed, 1));
    }
}
