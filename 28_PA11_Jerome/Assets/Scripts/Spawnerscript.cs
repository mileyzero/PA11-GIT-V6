using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    public GameObject SpawnObject1;
    public GameObject SpawnObject2;
    float PositionY;
    float Rand;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        Rand = Random.Range(1, 4);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        if(Rand == 1)
        {
            Instantiate(SpawnObject, transform.position, transform.rotation);
        }

        if(Rand == 2)
        {
            Instantiate(SpawnObject1, transform.position, transform.rotation);
        }

        if(Rand == 3)
        {
            Instantiate(SpawnObject2, transform.position, transform.rotation);
        }
    }
}
