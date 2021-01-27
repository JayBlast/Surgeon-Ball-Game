using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideZoom : MonoBehaviour
{
    // Start is called before the first frame update
    Camera maincamera;
    public float zoomAMT = 60f;


    void Start()
    {
        maincamera = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        maincamera.fieldOfView = zoomAMT;
    }

    public void sliderZoom( float zoom)
    {
        zoomAMT = zoom;
    }
}
