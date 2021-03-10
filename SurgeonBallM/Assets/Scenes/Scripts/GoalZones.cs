using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZones : MonoBehaviour
{
    [SerializeField] public DamageController myDamage;
    //private bool sArea;
    // Start is called before the first frame update
    void Start()
    {
        //sArea = true;//defaults the players position within the surgical area
        myDamage.isDamaging = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDamage.isDamaging = false; //Turns on the damaging function on the AccuracyCalculator script
            myDamage.UpdateDamage();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDamage.isDamaging = true;//Turns off the damaging function on the AccuracyCalculator script
            myDamage.UpdateDamage();
        }
    }

    void Update()
    {
        if (myDamage.isDamaging)
            myDamage.UpdateDamage(); 
    }

}
