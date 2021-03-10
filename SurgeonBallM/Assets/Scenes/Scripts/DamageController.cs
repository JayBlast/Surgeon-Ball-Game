using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    public float playerDamage;//Variable for how much health the player has
    [SerializeField] public Text damageText;
    public bool isDamaging;
    [SerializeField] public Text checkDamage;

    private void Start()
    {
        UpdateDamage();
    }
    public AccuracyCalculator myAcc;

    public void UpdateDamage()
    {
       if (isDamaging == true)
       {
            playerDamage = playerDamage + 0.1f;//slowly increments the damage
       }
        checkDamage.text = isDamaging.ToString();
        damageText.text = "Damage: [" + playerDamage.ToString("0.0") + "]";//updates the text connected to this controller, as a float
        myAcc.UpdateAcc();
    }
}
    