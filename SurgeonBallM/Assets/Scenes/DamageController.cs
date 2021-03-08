using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    public float playerDamage;//Variable for how much health the player has
    [SerializeField] public Text damageText;

    private void Start()
    {
        UpdateDamage();
    }
    public AccuracyCalculator myAcc;

    public void UpdateDamage()
    {
        damageText.text = "Damage: [" + playerDamage.ToString("0.0") + "]";//updates the text connected to this controller, as a float
        myAcc.UpdateAcc();
    }
}
    