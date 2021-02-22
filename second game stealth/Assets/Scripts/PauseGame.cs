using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool pauseBool = false;

    public GameObject pauseMenuUI;
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public GameObject endScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) 
            && !startScreen.activeSelf
            && !gameOverScreen.activeSelf
            && !endScreen.activeSelf)
        {
            if (pauseBool)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Shooting.canShoot = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pauseBool = true;
    }

    public void Resume()
    {
        Shooting.canShoot = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pauseBool = false;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
