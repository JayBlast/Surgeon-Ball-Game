using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] public Text scoreText;
    public float score;
    [SerializeField] public LevelProgress myProg;
    public AccuracyCalculator myAcc;

    private void Start()
    {
        UpdateScore();
    }

    
    public void UpdateScore()
    {
        score = myProg.goalsCollected + myAcc.currentAcc; //Update this to include difficulties and times in the future
        scoreText.text = "Score: [" + score.ToString("0.0") + "]"; //updates the text connected to this controller, as a float
    }
    /*
    void Update()
    {
        scoreText.text = "Score: [" + score.ToString("0.0") + "]"; //updates the text connected to this controller, as a float
    }*/
}
