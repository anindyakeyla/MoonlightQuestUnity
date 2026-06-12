using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public int nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int unlockedLevel =
                PlayerPrefs.GetInt("UnlockedLevel", 1);

            if (nextLevel > unlockedLevel)
            {
                PlayerPrefs.SetInt(
                    "UnlockedLevel",
                    nextLevel
                );
            }

            MenuManager.openLevels = true;

            SceneManager.LoadScene("SampleScene");
        }
    }
}