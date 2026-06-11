using UnityEngine;

public class DamageHealth : MonoBehaviour
{
    public int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = 
            other.GetComponentInParent<PlayerHealth>();

        if (playerHealth != null)
        {
            Destroy(gameObject);
            Debug.Log("Damaging player!");
            playerHealth.TakeDamage(damage);
        }
    }
}
