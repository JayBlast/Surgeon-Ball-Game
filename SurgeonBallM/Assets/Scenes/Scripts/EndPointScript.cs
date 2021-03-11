using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //if player has reached level requirements, end level
            //else put a transluscent message "Make sure to cut along all points of the marked area before proceeding!"
        }
    }
}
