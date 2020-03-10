using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float newY = 27.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            newY += 6.325f;
        }
        
        //transform.position = new Vector3(0,newY,-8);
        Vector3 desiredPosition = new Vector3(0, newY, -157.76f);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, 1f * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
