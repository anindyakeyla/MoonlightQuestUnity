using UnityEngine;

public class GhostEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HealthManager.instance.LoseHealth();

            other.GetComponent<PlayerMovement>().Respawn();
        }
    }
}