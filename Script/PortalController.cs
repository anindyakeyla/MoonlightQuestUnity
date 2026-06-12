using UnityEngine;
using System.Collections;

public class PortalController : MonoBehaviour
{
    public Transform destination;

    private static bool canTeleport = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && canTeleport)
        {
            collision.transform.position = destination.position;

            StartCoroutine(TeleportCooldown());
        }
    }

    IEnumerator TeleportCooldown()
    {
        canTeleport = false;

        yield return new WaitForSeconds(0.5f);

        canTeleport = true;
    }
}