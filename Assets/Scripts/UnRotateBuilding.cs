using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnRotateBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.enabled = false)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Vector3.forward * (91 * Time.deltaTime));
    }

}
