using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explodeEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        } else
        {
            ScoreKeeper.score += 10;
            ScoreKeeper.scoreChange = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(explodeEffect, transform.position, Quaternion.identity);
        }
    }
}
