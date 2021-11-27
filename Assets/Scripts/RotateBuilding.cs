using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(this.enabled = false)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * (91 * Time.deltaTime));
    }

    public void rotateBuild()
    {     
        
        transform.Rotate(Vector3.forward * (10 * 5));
        
    }

    public void unrotateBuild()
    {
        transform.Rotate(0, 0, -90);
    }

}
