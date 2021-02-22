using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public GameObject explodeEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
        //else if (collision.gameObject.CompareTag("ForceField"))
        //{
        //    // continue
        //    Ray2D ray = new Ray2D(transform.position, transform.right);
        //    Vector2 v = Vector2.Reflect(ray.direction, transform.right);
        //    float rot = 90 - Mathf.Atan2(v.x, v.y) * Mathf.Rad2Deg;
        //    transform.eulerAngles = new Vector3(0, 0, rot);
        //}
        //else if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    Health enemyHealth = collision.gameObject.GetComponent<Health>();
        //    enemyHealth.TakeDamage(1);
        //    if (enemyHealth.isDepleted)
        //    {
        //        ScoreKeeper.score -= 1;
        //        ScoreKeeper.scoreChange = true;
        //        Destroy(collision.gameObject);
        //        GameObject explode = Instantiate(explodeEffect, transform.position, Quaternion.identity);
        //        StartCoroutine(Wait(explode));
        //    }
        //    Destroy(gameObject);
        //}
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
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
        }
        else
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
