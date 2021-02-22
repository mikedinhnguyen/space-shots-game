using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explodeEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            playerHealth.TakeDamage(1);
            if (playerHealth.isDepleted)
            {
                DestroyPlayer destroyer = GameObject.Find("Player").GetComponent<DestroyPlayer>();
                destroyer.DestroySelf(collision);
            }
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Health enemyHealth = collision.gameObject.GetComponent<Health>();
            enemyHealth.TakeDamage(1);
            if (enemyHealth.isDepleted)
            {
                ScoreKeeper.score -= 1;
                ScoreKeeper.scoreChange = true;
                Destroy(collision.gameObject);
                GameObject explode = Instantiate(explodeEffect, transform.position, Quaternion.identity);
                StartCoroutine(Wait(explode));
            }
            Destroy(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Wait(GameObject explode)
    {
        yield return new WaitForSeconds(2);
        Destroy(explode);
    }
}
