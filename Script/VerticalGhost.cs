using UnityEngine;

public class VerticalGhost : MonoBehaviour
{
    public float topLimit;
    public float bottomLimit;
    public float speed = 2f;

    bool movingUp = true;

    void Update()
    {
        if (movingUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);

            if (transform.position.y >= topLimit)
                movingUp = false;
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);

            if (transform.position.y <= bottomLimit)
                movingUp = true;
        }
    }

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
}