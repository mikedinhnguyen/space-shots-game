using System.Collections;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform target;
    public Transform bulletPoint;
    public GameObject bulletPreFab;

    public float bulletForce;
    public float fireRate;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        StartCoroutine(Shooting());
    }

    IEnumerator Shooting()
    {
        if (target != null)
        {
            yield return new WaitForSeconds(fireRate);
            Shoot();
            StartCoroutine(Shooting());
        } else { }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPreFab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
