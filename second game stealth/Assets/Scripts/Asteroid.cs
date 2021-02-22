using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Transform target;
    public Transform asteroidDir;
    private Rigidbody2D rb;

    public float asteroidForce;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target != null)
        {
            LookAtPlayer();
        }
    }

    void LookAtPlayer()
    {
        Vector2 lookDir = target.position - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            rb.AddForce(asteroidDir.up * asteroidForce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
