using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static bool openLevels = false;

    public GameObject menuUI;
    public GameObject levelsUI;

    void Start()
    {
        if (openLevels)
        {
            menuUI.SetActive(false);
            levelsUI.SetActive(true);

            openLevels = false;
        }
    }
}