using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZones : MonoBehaviour
{
    
    [SerializeField] public DamageController myDamage;

    void Start()
    {
        //Physics.IgnoreCollision(GetComponent<Collider>()  //second entry with something.GetComponent<Collider>())
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDamage.isDamaging = false;//Turns off the damaging function on the AccuracyCalculator script
            myDamage.UpdateDamage();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDamage.isDamaging = true;
            //myDamage.playerDamage = myDamage.playerDamage + 0.1f;
            myDamage.UpdateDamage();
        }
    }
    /*
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            myDamage.playerDamage = myDamage.playerDamage + 0.1f;
            myDamage.UpdateDamage();
    }*/
    /*
        void Update()
        {
            if (isDamaging)
            {
                myDamage.playerDamage = myDamage.playerDamage + 0.1f;
                myDamage.UpdateDamage();
            }
            //Debug.Log(damage);// get this to work
        }*/
}
