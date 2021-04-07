//The script mamnages the behavoir of the "Goal Points" that need to be "collected" by the player in order to complete the level
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalPointScript : MonoBehaviour
{
    [SerializeField] public LevelProgress myProg;//allows access to the functions and data of the LevelProgress script
    [SerializeField] public ScoreController myScore;//allows access to the functions and data of the score controller script

    void OnTriggerEnter(Collider other)//Triggers if this object detects some other object entering it
    {
        if (other.CompareTag("Player"))//if the object has tag "Player"
        {
            myProg.goalsCollected++;//increments the count of goal points collected
            myProg.UpdateProgress();//triggers the level progress within the level progress script to update
            Destroy(gameObject);//destroys this instance of goal point so it can't be collected multiple times
        }
    }
}
