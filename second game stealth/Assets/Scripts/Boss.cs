using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject boss;
    public GameObject endScreen;

    void Update()
    {
        if (boss == null)
        {
            endScreen.SetActive(true);
            Spawner.isSpawning = false;
            Shooting.canShoot = false;
        } 
    }
}
