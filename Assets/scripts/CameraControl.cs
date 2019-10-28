using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float cameraChange;
    public float cameraY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cameraChange++;
            if (cameraChange == 3)
            {
                cameraChange = 0;
            }
        }

        if (cameraChange == 0)
        {
            cameraY = 18;
        }
        else if (cameraChange == 1)
        {
            cameraY = 47;
        }
        else if (cameraChange == 2)
        {
            cameraY = 123;
        }

        transform.position = new Vector3(transform.position.x, cameraY, transform.position.z);
    }
}
