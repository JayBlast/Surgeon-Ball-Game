//This script manages the score
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] public Text scoreText;//allows for the connection between this script and the score display box
    public float score;//variable for the score
    [SerializeField] public LevelProgress myProg;//allows access to the functions and data of the DamageController script
    public AccuracyCalculator myAcc;//allows access to the functions and data of the Accuracy Calculator script

    private void Start()
    {
        UpdateScore();//Updates score at start of scene
    }
    public void UpdateScore()
    {
        score = myProg.goalsCollected + myAcc.currentAcc; //Update this to include difficulties and times in the future
        scoreText.text = "Score: [" + score.ToString("0.0") + "]"; //updates the text connected to this controller, as a float
    }
}
