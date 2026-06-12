using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("UnlockedLevel"))
        {
            PlayerPrefs.SetInt("UnlockedLevel", 1);
        }
    }
}