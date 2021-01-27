using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isFlat = true;
    private Rigidbody rigid;
    public float speed = 10.0f;// sets extra speed

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt; //rotates the physics 90 degrees

        rigid.AddForce(Input.acceleration);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
    }
}
