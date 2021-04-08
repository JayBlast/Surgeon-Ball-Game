//Script for the Damage display UI element
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageDisplayScript : MonoBehaviour
{
    public Text displayText;
    // Start is called before the first frame update
    public DamageController myDamage;//provides access to the data and functions of the data controller script
    void Update()
    {
       displayText.text = myDamage.playerDamage.ToString();//updates itself to match the damage number from the damage controller
    }
}
