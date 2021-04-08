//Script for damage zone detection. Assigned to every object that is meant to apply damage to the character
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZones : MonoBehaviour
{
    [SerializeField] public DamageController myDamage;//provides access to the functions and data of the data controller script

    private void OnTriggerStay(Collider other)//runs when this objects detects another object staying within it
    {
        if (other.CompareTag("Player"))//if the colliding object has the tag "Player"
        {
            myDamage.isDamaging = true;//Turns off the damaging boolean on the damage controller script
            myDamage.UpdateDamage();//triggers damage calculator to update
        }
    }
    private void OnTriggerExit(Collider other)//runs when this objects detects that another object is leaving it
    {
        if (other.CompareTag("Player"))//if the colliding object has the tag "Player"
        {
            myDamage.isDamaging = false;//Turns off the damaging boolean on the damage controller script
            myDamage.UpdateDamage();//triggers damage calculator to update
        }
    }
}
