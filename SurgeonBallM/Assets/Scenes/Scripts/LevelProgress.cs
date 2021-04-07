//This script mamages the progress of the given level
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] public int totalGoals;// total goals on a given level to collect
    public int goalsCollected;//number of goals collected on the level
    public int goalsRemaining;//remaining number of the goals in the level before the win condition is met
    [SerializeField] public Text progText;//allows for the connection between this script and the level progress display box

    private void Start()
    {
        UpdateProgress();//Calls the progress of the level to update when the scene is started
    }

    public void UpdateProgress()
    {
        goalsRemaining = totalGoals - goalsCollected;//calculates the remaining goals as the total goals minus the goals collected
        progText.text = "Progress: [" + goalsCollected.ToString("0") + "/" + totalGoals.ToString("0") + "]"; //updates the text connected to this controller, as a float
    }
}
