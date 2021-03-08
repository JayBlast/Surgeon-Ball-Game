using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZones : MonoBehaviour
{
    //[SerializeField] private bool isDamaging = false;
    //[SerializeField] public double damage = 0.0;
    [SerializeField] public DamageController myDamage;
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDamaging = true; //Turns on the damaging function on the AccuracyCalculator script
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDamaging = false;//Turns off the damaging function on the AccuracyCalculator script
        }
    }*/
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            myDamage.playerDamage = myDamage.playerDamage + 0.1f;
            myDamage.UpdateDamage();
    }
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
