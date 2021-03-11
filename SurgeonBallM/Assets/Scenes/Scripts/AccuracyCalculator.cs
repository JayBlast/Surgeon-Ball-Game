using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyCalculator : MonoBehaviour
{
    //Accuracy = max_Accuracy - Difficulty*(error_zone_collision_count)
    // Start is called before the first frame update
    [SerializeField] public float maxAcc;
    public float currentAcc;

    [SerializeField] public Text accText;

    public DamageController myDamage;
    public ScoreController myScore;
        
    private void Start()
    {
        UpdateAcc();
    }

    // Update is called once per frame
    public void UpdateAcc()
    {
        currentAcc = maxAcc - myDamage.playerDamage;
        accText.text = "Accuracy: [" + currentAcc.ToString("0.0") + "%]"; //updates the text connected to this controller, as a float
        myScore.UpdateScore();
    }
}

