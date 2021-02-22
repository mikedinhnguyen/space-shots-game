using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void SelectLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
