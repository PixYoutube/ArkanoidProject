using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public static void LoadScenes(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
