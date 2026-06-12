using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    public Image[] hearts;

    private int health;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        health = hearts.Length;
        UpdateHearts();
    }

    public void LoseHealth()
    {
        Debug.Log("LoseHealth dipanggil!");

        if (health <= 0)
            return;

        health--;

        Debug.Log("Health sekarang = " + health);

        UpdateHearts();

        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < health;
        }
    }
}