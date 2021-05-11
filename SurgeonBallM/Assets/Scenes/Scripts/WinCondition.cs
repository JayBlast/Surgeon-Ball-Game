//This script mamages the win condition for the level
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] public LevelProgress myProg;//allows access to the functions and data of the LevelProgress script
    [SerializeField] public ScoreController myScore;//allows access to the functions and data of the score controller script
    [SerializeField] public AccuracyCalculator myAcc;//provides access to the functions and data of the accuracy calculator script
    //[SerializeField] public PassScore pass;//allows access to the data and functions of the object that passes data between scenes
    public float scoreFinal;//This score is calculated when the win condition in met
    public float accFinal;//This accuracy is calculated when the win condition in met

    void Update()
    {
        if (myProg.goalsRemaining == 0)//checks to see if all of the goalpoints have been collected before proceeding
        {
            myProg.progText.text = "Winner!";//displays "Winner" on the level progress UI (mainly used for testing scene transition)
            scoreFinal = myScore.score; //This is the score to be added into the leaderboard database
            accFinal = myAcc.currentAcc;//(This value is calculated but is currently not in use)
            ScorePasserScript.instance.updatePasser(scoreFinal);//Calls the function within the static instance of ScorePasserScript, passing a number into it
            myProg.progText.text = "Passer Udpated";
            //SceneManager.LoadScene("LeaderBoard");//this triggers a transition to the Leaderboard scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//alternate function to change the scene
            myProg.progText.text = "Next scene";
        }
    }
}
    