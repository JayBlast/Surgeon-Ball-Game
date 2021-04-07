//This is the script for the object reponsible for carrying scores between levels for the purpose of updating the scoreboard
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScore : MonoBehaviour
{
    [SerializeField] public WinCondition win;
    public float scoreFinal;
    public float accFinal;
    void Awake()
    {
        GameObject scoreHolder = GameObject.Find("ScoreHolder");
        DontDestroyOnLoad(this.gameObject);
    }
    public void passScore()
    {
        scoreFinal = win.scoreFinal;
        accFinal = win.accFinal;
    }
}
