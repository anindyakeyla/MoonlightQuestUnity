using UnityEngine;

public class FallZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HealthManager.instance.LoseHealth();

            collision.GetComponent<PlayerMovement>().Respawn();
        }
    }
}