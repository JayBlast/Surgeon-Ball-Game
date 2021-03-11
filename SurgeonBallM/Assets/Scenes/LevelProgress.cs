using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] public int totalGoals;// total goals on a given level to collect
    public int goalsCollected;// number of goals collected on the level
    public int goalsRemaining;
    [SerializeField] public Text progText;
    //public bool levelComplete

    private void Start()
    {
        UpdateProgress();
    }

    public void UpdateProgress()
    {
        goalsRemaining = totalGoals - goalsCollected;
        progText.text = "Progress: [" + goalsCollected.ToString("0") + "/" + totalGoals.ToString("0") + "]"; //updates the text connected to this controller, as a float
        
    }

}
