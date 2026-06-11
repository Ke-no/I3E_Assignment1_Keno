using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHeath = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHeath;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("Heath: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Player Died...");
        }
    }
}
