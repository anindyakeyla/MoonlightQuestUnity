using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource audioSource;

    bool collected = false;

    void Start()
    {
        audioSource =
            GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")
           && !collected)
        {
            collected = true;

            CoinManager.instance.AddCoin(); // ? INI PENTING

            audioSource.Play();

            GetComponent<SpriteRenderer>()
                .enabled = false;

            GetComponent<Collider2D>()
                .enabled = false;

            Destroy(gameObject, 0.5f);
        }
    }
}