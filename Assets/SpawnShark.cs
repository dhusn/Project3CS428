using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{

    public Rigidbody shark;
    public Transform spawnLocation;
    //bool boolType = false;
    //private float timer = 0f;
    float nextTime = 0f;
    float timer = 0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer>=nextTime)
        {


            Instantiate(shark, spawnLocation.position, spawnLocation.rotation);

            nextTime += 25f;
        }
        timer += 0.1f;
     
    }

    
}
