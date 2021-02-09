using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bulletPreFab;

    public float bulletForce;

    void Start()
    {
        StartCoroutine(Shooting());
    }

    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(1);
        Shoot();
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPreFab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
