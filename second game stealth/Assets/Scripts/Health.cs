using UnityEngine;

public class Health : MonoBehaviour
{
    public bool isDepleted;
    public int health;
    public HealthBar healthBar;

    void Start()
    {
        isDepleted = false;
        healthBar.SetMaxHealth(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            isDepleted = true;
        }
        healthBar.SetHealth(health);
    }
}
