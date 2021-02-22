using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bulletPreFab;
    public AudioSource bulletSound;

    public float bulletForce;
    float fireRate = 0.2f;
    float fireRatePointer;
    public static bool canShoot;
    
    void Update()
    {
        if (Input.GetButton("Fire1") && canShoot && Time.time > fireRatePointer)
        {
            Shoot();
            bulletSound.Play();
            fireRatePointer = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPreFab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
    }

    public void CanShootFunction()
    {
        canShoot = true;
    }
}
