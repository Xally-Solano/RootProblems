using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class HighScore : MonoBehaviour
{

    private float cronom = 0f;
    private GameObject player;
    private PlayerControllerV2 playercontroller;

    private float SCORE = 0f;

    //

    public int roundedScore;

    public int highestScore = 0;

    string highScoreKey = "HighScore";
    //string highestScoreString;



    // Start is called before the first frame update
    void Start()
    {
        //int highestS = PlayerPrefs.GetInt(highScoreKey, 0);
        //highestScoreString = highestS.ToString();


        player = GameObject.Find("Robotson");

        playercontroller = player.GetComponent<PlayerControllerV2>();

        highestScore = PlayerPrefs.GetInt(highScoreKey, 0);

    }

    // Update is called once per frame
    void Update()
    {
        cronom += Time.deltaTime;
        CalculateScore();
        
    }

    void CalculateScore()
    {
        SCORE = (playercontroller.enemiesBeaten / cronom) * 1000;

        roundedScore = Mathf.FloorToInt(SCORE);

        if (roundedScore > highestScore)
        {
            highestScore = roundedScore;
            PlayerPrefs.SetInt(highScoreKey, highestScore);
            PlayerPrefs.Save();
        }
    }

}
