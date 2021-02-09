using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSpawn : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f;
        Shooting.canShoot = false;
    }

    public void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }   
    }
}
