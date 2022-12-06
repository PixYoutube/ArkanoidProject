using UnityEngine;

public class Player : MonoBehaviour
{
    // Mouse sensitivity
    [SerializeField] float sens;
    float xPosition;

    #region Meths Unity
    private void Update()
    {
        PlayerMouvement();
    }
    #endregion
    #region Meths
    #region Mouvements
    void PlayerMouvement()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sens;
        xPosition += mouseX;
        xPosition = Mathf.Clamp(xPosition, -3f, 3f);
        transform.position = new Vector3(xPosition, 0, 0);
    }
    #endregion
    #region Game Over
    public static void GameOver(string _menuGameOver)
    {
        Scores.ResetPoints();
        SceneLoader.LoadScenes(_menuGameOver);
        Debug.Log("Game Over !");
    }
    #endregion
    #region Win
    public static void Win(string _lvl)
    {
        SceneLoader.LoadScenes(_lvl);
        Debug.Log("Win !");
    }
    #endregion
    #endregion
}
