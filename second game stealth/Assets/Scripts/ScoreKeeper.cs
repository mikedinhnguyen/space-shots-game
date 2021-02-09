using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static int score;
    public static bool scoreChange = false;
    public GameObject endScreen;
    public GameObject enemiesLeftText;
    public GameObject scoreText;
    public Text newScore;

    // Update is called once per frame
    private void Update()
    {
        if (score <= 0)
        {
            UpdateScore();
            Spawner.isSpawning = false;
            endScreen.SetActive(true);
            enemiesLeftText.SetActive(false);
            scoreText.SetActive(false);
        }

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
