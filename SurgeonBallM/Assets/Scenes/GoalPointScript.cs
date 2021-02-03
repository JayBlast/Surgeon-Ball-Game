using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPointScript : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            //later add functionality that ends level when all of this object is destroyed
        }
    }
}
