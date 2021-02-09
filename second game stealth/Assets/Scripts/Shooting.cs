using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bulletPreFab;
    public AudioSource bulletSound;

    public float bulletForce;
    public static bool canShoot;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            Shoot();
            bulletSound.Play();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPreFab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
    }

    public void canShootFunction()
    {
        canShoot = true;
    }
}
