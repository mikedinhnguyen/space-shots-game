using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject[] spawn_points;
    public GameObject[] enemies;
    public float waitTime;
    public GameObject target;
    public static bool isSpawning;

    // Start is called before the first frame update
    void Start()
    {
        isSpawning = true;
        spawn_points = GameObject.FindGameObjectsWithTag("EnemySpawn");
        target = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        Transform spawnPos = spawn_points[Random.Range(0, spawn_points.Length)].transform;

        if (target == null || !isSpawning)
        {
            yield break;
        }

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(SpawnEnemy());
    }
}
