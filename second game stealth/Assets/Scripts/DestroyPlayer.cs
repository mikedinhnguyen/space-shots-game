using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject explodeEffect;
    public AudioSource explodeSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            explodeSound.Play();
            Instantiate(explodeEffect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
