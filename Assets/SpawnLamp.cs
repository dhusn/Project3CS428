using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLamp : MonoBehaviour
{
    public Rigidbody lamp;
    public Transform spawnLocation;
    //bool boolType = false;
    //private float timer = 0f;
    float nextTime = 0f;
    float timer = 0f;

    void start()
    {
        if (this.enabled = false)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= nextTime)
        {


            Instantiate(lamp, spawnLocation.position, spawnLocation.rotation);

            nextTime += 30f;
        }
        timer += 0.1f;

    }
}
