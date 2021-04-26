//Script that controlls how damage is calculated
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    public float playerDamage;//Variable for how much health the player has
    [SerializeField] public Text damageText;//allows connection to damage label
    public bool isDamaging;//a boolean for keeping track of whether the player is getting damamged or not
    [SerializeField] public Text checkDamage;//allows connection to the "Is Damaging?" label in the UI. This label was made because the Debug menu does not show on the android

    private void Start()
    {
        UpdateDamage();//updates the damage as the game starts
    }
    public AccuracyCalculator myAcc;//provides access to the functions and data of the accuracy calculator script

    public void UpdateDamage()
    {
       if (isDamaging == true)//only occurs if data works
       {
            playerDamage = playerDamage + 0.01f;//slowly increments the damage
       }
        checkDamage.text = isDamaging.ToString();//updates the UI to show whether or not the player should be taking damage.
        damageText.text = "Damage: [" + playerDamage.ToString("0.0") + "]";//updates the text connected to this controller, as a float
        myAcc.UpdateAcc();//call to update the accuracy
    }
}
    