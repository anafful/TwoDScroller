using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{

    private float startPos;
    private GameObject Cam;
    [SerializeField]
    float parallaxEffect;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cam = GameObject.Find("CM vcam1");
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (Cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
    }
}
