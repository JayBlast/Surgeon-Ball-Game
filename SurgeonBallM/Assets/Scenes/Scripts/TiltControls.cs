//this script allows for the scalpel to be controlled by the phone's accelerometer
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{
    //Move object using accelerometer
    float speed = 5.0f;
   
    void Update()
    {
        Vector3 dir = Vector3.zero;//Stops the object from spinning out of control
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
        //Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;
        //moves the object
        transform.Translate(dir * speed);
    }
}
