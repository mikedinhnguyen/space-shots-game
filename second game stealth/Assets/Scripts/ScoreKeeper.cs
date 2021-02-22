using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int initialScore;
    public static int score;
    public static bool scoreChange = false;
    public GameObject endScreen;
    public GameObject enemiesLeftText;
    public GameObject scoreText;
    public Text newScore;

    private void Start()
    {
        score = initialScore;
    }

    // Update is called once per frame
    private void Update()
    {
        if (score <= 0)
        {
            UpdateScore();
            Spawner.isSpawning = false;
            Shooting.canShoot = false;
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
