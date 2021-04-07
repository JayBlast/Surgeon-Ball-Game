//This script manages the behavior of objects that mark the area within the player is supposed to opperate
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZones : MonoBehaviour
{
    [SerializeField] public DamageController myDamage;//allows access to the functions and data of the DamageController script
    void Start()
    {
        myDamage.isDamaging = false;//when the scene starts, this makes it so that the damge defaults to off. 
        //This functionality is implemented here because the player is meant to start in a goal zone
    }
    private void OnTriggerEnter(Collider other)//runs when this object detects another object entering it
    {
        if (other.CompareTag("Player"))//if the colliding object has the tag "Player"
        {
            myDamage.isDamaging = false; //Turns on the damaging function on the AccuracyCalculator script
            myDamage.UpdateDamage();//calls to update the damage calculator so it can register the change in damage state
        }
    }
    private void OnTriggerExit(Collider other)//runs when this objects detects that another object is leaving it
    {
        if (other.CompareTag("Player"))//if the colliding object has the tag "Player"
        {
            myDamage.isDamaging = true;//Turns off the damaging function on the AccuracyCalculator script
            myDamage.UpdateDamage();//calls to update the damage calculator so it can register the change in damage state
        }
    }

    void Update()
    {
        if (myDamage.isDamaging)//assures that the damage is always updating 
            myDamage.UpdateDamage();//essentially this means that withing actual damage zones, the damage inflicted it two-fold, but only applies once when leaving the goalzone area
    }
}
