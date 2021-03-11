using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalPointScript : MonoBehaviour
{
    [SerializeField] public LevelProgress myProg;
    [SerializeField] public ScoreController myScore;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myProg.goalsCollected++;
            Destroy(gameObject);            
            myProg.UpdateProgress();


        }
    }
}
