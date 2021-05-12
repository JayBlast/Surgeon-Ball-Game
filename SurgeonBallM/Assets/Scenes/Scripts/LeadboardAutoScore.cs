//this script automatically grabs the score from the object that exists between scenes and throws it onto the leaderboard submission button
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LeadboardAutoScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScorePasserScript.instance.passerText = GameObject.Find("Textpasser").GetComponent<Text>();
        ScorePasserScript.instance.textUpdate();
    }

}
