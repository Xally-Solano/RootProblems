using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetHighestScore : MonoBehaviour
{
    string highScoreKey = "HighScore";
    
    TextMeshProUGUI HighScoreTMP;

    
    // Start is called before the first frame update
    void Start()
    {
        HighScoreTMP = GetComponent<TextMeshProUGUI>();
        int highestScore = PlayerPrefs.GetInt(highScoreKey, 0);
        HighScoreTMP.text = ""+ highestScore;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHighest()
    {
        HighScoreTMP = GetComponent<TextMeshProUGUI>();
        int highestScore = PlayerPrefs.GetInt(highScoreKey, 0);
        HighScoreTMP.text = "" + highestScore;
    }

}
