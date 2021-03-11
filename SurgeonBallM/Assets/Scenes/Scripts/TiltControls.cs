using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{
    // Start is called before the first frame update
    //Move object using accelerometer
    float speed = 5.0f;

    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        // we assume that device is held in portrait mode
        // and Home button is near the thumb

        // remap device acceleration axis to game coordinates:
        //  1) X direction follows rotation of phone
        //  2) Z direction is is calculated operating away from the camera
        dir.x = Input.acceleration.x;
        dir.z = -Input.acceleration.z;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        //Make it move 10 meters per second instrad of 10 meters per frame...

        dir *= Time.deltaTime;

        //move object
        transform.Translate(dir * speed);

    }
}
