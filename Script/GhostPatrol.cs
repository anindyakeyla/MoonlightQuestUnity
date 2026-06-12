using UnityEngine;

public class GhostPatrol : MonoBehaviour
{
    public float leftLimit;
    public float rightLimit;
    public float speed = 2f;

    bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= rightLimit)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= leftLimit)
                movingRight = true;
        }
    }
}