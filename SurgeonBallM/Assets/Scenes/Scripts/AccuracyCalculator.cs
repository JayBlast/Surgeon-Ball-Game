using System.Collections;
//Script that chooses how and when accuracy is calculated
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyCalculator : MonoBehaviour
{
    //Accuracy = max_Accuracy - Difficulty*(error_zone_collision_count)
    // Start is called before the first frame update
    [SerializeField] public float maxAcc; //this allows the max accuracy to be entered within the inspector
    public float currentAcc;//value for current accuracy at a given time
    [SerializeField] public Text accText;//value that is used to update the Accuracy text label

    public DamageController myDamage;//provides access to data and functions within DamageController script
    public ScoreController myScore;//provides access to data and functions within score script

    private void Start()
    {
        UpdateAcc();//calls to update the accuracy on game start
    }

    // Update is called once per frame
    public void UpdateAcc()
    {
        currentAcc = maxAcc - myDamage.playerDamage;//calculates current accuracy by subtracting the current total damage the player has taken from the max accuracy
        accText.text = "Accuracy: [" + currentAcc.ToString("0.0") + "%]";//Updates the accuracy label text
        myScore.UpdateScore();//calls to update the score
    }
}

