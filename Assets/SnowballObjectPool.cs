using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballObjectPool : MonoBehaviour
{
    public static SnowballObjectPool instance;

    public float launchVelocity = 10f;
    Vector3 velocity;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 10;

    [SerializeField]
    GameObject snowballPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(snowballPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);


        }
    }

    public GameObject GetPooledObjects()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {

                //Rigidbody rb = snowballPrefab.GetComponent<Rigidbody>();
                //if (rb)
                //{
                //    rb.velocity = velocity;
                //    rb.AddForce(rb.transform.forward * launchVelocity, ForceMode.Impulse);



                   
                //}
                return pooledObjects[i];
            }
          
        }
        return null;
    }
}
