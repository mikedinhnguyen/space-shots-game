using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject explodeEffect;
    public AudioSource explodeSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health playerHealth = GameObject.Find("Player").GetComponent<Health>();
            Health enemyHealth = collision.gameObject.GetComponent<Health>();
            playerHealth.TakeDamage(2);
            enemyHealth.TakeDamage(2);

            if (enemyHealth.isDepleted && playerHealth.isDepleted)
            {
                DestroySelf(collision);
            }
            else if (enemyHealth.isDepleted)
            {
                ScoreKeeper.score -= 1;
                ScoreKeeper.scoreChange = true;
                Instantiate(explodeEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else if (playerHealth.isDepleted)
            {
                explodeSound.Play();
                Instantiate(explodeEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }

    public void DestroySelf(Collision2D collision)
    {
        explodeSound.Play();
        Instantiate(explodeEffect, transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    public void DestroySelf(Collider2D collision)
    {
        explodeSound.Play();
        Instantiate(explodeEffect, transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
