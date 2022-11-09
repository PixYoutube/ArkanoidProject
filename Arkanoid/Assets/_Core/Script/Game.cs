using UnityEngine;

public class Game : MonoBehaviour
{
    // Define Briks object parent and Layers
    [SerializeField] GameObject parent;
    int Layers = 6;

    #region Meths Unity
    private void Update()
    {
        // When he Win
        if(parent.transform.childCount == 0)
        {
            Player.Win();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When he loses
        if(collision.gameObject.layer == Layers)
        {
            Player.GameOver();
        }
    }
    #endregion
}
