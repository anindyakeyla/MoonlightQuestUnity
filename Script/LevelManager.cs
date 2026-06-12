using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void OpenScene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OpenScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void OpenScene3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void OpenScene4()
    {
        SceneManager.LoadScene("Scene4");
    }

    public void OpenScene5()
    {
        SceneManager.LoadScene("Scene5");
    }
}