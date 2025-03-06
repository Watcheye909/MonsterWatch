using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class ResultsScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI searchText;
    //public GameManagerScript GMS;

    public int searchesUsed;

    // Start is called before the first frame update
    void Start()
    {
        //NOTE: JUST REALIZED THAT THE STATS VARIABLES ARE NOT GOING TO CARRY FROM GameManagerScript TO THIS SCRIPT SO GL :(
        searchesUsed = 20;

        string Score = PlayerPrefs.GetString("Score");
        scoreText.text = Score;
    }

    // Update is called once per frame
    void Update()
    {
        

        string Score = PlayerPrefs.GetString("Score");
        scoreText.text = Score;

    }

    /*
    //used to display the game score
    public void ScoreResults()
    {
        //I just made it so you can refer the variable using GMS.score or whatever else you named the score variable stuff
        scoreText.text = "SCORE: (SCORE VARIABLE HERE)";

    }
    */

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Debug.Log("loading start scene");
    }
}
