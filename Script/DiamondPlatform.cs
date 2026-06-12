using UnityEngine;
using System.Collections;

public class DiamondPlatform : MonoBehaviour
{
    [Header("Platform Settings")]
    public float disappearDelay = 0.5f;
    public float respawnTime = 3f;

    [Header("Blink Settings")]
    public int blinkCount = 3;
    public float blinkSpeed = 0.1f;

    private SpriteRenderer spriteRenderer;
    private Collider2D platformCollider;
    private bool isTriggered = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        platformCollider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isTriggered && collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DisappearRoutine());
        }
    }

    IEnumerator DisappearRoutine()
    {
        isTriggered = true;

        // Tunggu sebentar setelah diinjak
        yield return new WaitForSeconds(disappearDelay);

        // Efek berkedip
        for (int i = 0; i < blinkCount; i++)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(blinkSpeed);

            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(blinkSpeed);
        }

        // Hilang
        spriteRenderer.enabled = false;
        platformCollider.enabled = false;

        // Tunggu sebelum muncul lagi
        yield return new WaitForSeconds(respawnTime);

        // Muncul lagi
        spriteRenderer.enabled = true;
        platformCollider.enabled = true;

        isTriggered = false;
    }
}