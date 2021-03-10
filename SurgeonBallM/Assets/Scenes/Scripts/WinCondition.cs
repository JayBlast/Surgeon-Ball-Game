using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] public LevelProgress myProg;
    [SerializeField] public ScoreController myScore;
    [SerializeField] public AccuracyCalculator myAcc;
    public float scoreFinal;
    public float accFinal;
    
    // Update is called once per frame
    void Update()
    {
        if (myProg.goalsRemaining == 0)
        {
            scoreFinal = myScore.score; //This is the score to be added into the leaderboard database
            accFinal = myAcc.currentAcc;
            SceneManager.LoadScene("startScreen");
            //Jay make this next line work please
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//ends level
        }
    }
}
    