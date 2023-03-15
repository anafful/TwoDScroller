using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
   // public GameObject Player;


    public float speed = 2f;
    public Vector3 startPosition;
    public Vector3 endPosition;

    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(startPosition.x, startPosition.y + 5f, startPosition.z);
    }


    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time * speed, 1));
    }

    

}
