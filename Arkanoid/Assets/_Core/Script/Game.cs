using UnityEngine;

public class Game : MonoBehaviour
{
    // Define Briks object parent and Layers
    [SerializeField] GameObject parent;
    [SerializeField] string nextLvl;
    [SerializeField] string menuGameOver;
    int Layers = 6;

    #region Meths Unity
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        // When he Win
        if(parent.transform.childCount == 0)
        {
            Player.Win(nextLvl);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When he loses
        if(collision.gameObject.layer == Layers)
        {
            Player.GameOver(menuGameOver);
        }
    }
    #endregion
}
