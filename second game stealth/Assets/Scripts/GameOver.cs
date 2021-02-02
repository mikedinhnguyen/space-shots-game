using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject player;
    public GameObject gameOverUI;

    void Update()
    {
        if (player == null)
        {
            GameOverScreen();
        }
    }

    void GameOverScreen()
    {
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
