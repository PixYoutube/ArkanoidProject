using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Meths Unity
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    #endregion
    #region Meths
    public static void LoadScenes(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }
    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}
