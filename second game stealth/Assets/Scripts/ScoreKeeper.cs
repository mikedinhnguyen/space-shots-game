using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static int score = 0;
    public static bool scoreChange = false;
    public Text newScore;

    // Update is called once per frame
    private void Update()
    {
        if (scoreChange)
        {
            UpdateScore();
            scoreChange = false;
        } 
    }

    private void UpdateScore()
    {
        newScore.text = score.ToString();
    }
}
