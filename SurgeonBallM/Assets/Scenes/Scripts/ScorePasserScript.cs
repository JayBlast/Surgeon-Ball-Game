//Script for letting scores exist betweeen scenes for the purpose of updating the scoreboard
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScorePasserScript : MonoBehaviour
{
    public static ScorePasserScript instance = null;//creates an instance of this class, 
    public Text passerText;//the text box attatched to this script
    public float scoreP = 0;//the score to be passed between scenes
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a ScorePasserScript.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        passerText = GameObject.Find("Textpasser").GetComponent<Text>();//searches the scene for an object named Textbox and assigns itself to its Text component (If both exist)
        //passerText.text = scoreP.ToString();
    }
    public void updatePasser(float f)
    {
        scoreP = f;
        passerText.text = scoreP.ToString();//Updates the score then updates the text to match the score
    }
    public void textUpdate()
    {
        passerText.text = scoreP.ToString();//updates the text to match the score
    }
}
