using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMenu : MonoBehaviour
{

    void Start()
    {
        Shooting.canShoot = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
