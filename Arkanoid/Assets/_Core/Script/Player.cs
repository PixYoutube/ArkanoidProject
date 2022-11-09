using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Score
    public static int Score;
    public static int HightScore;
    Text text;

    // Player speed
    [SerializeField] float Speed = 0.01f;

    #region Meths Unity
    private void Start()
    {
        // Set score and restore hight score
        text = GetComponent<Text>();
        ResetPoints();
        HightScore = PlayerPrefs.GetInt("HightScore", HightScore);
        text.text = HightScore.ToString();
    }
    private void Update()
    {
        // Links between Score and HightScore
        if(Score > HightScore)
        {
            HightScore = Score;
            text.text = "" + Score;
            PlayerPrefs.SetInt("HightScore", HightScore);
            PlayerPrefs.Save();
        }

        PlayerMouvement();
    }
    #endregion
    #region Meths
    #region Points
    public static void AddPoints(int _pointsToAdd)
    {
        // Set points
        Score += _pointsToAdd;
    }
    public static void ResetPoints()
    {
        // Reset points
        Score = 0;
    }
    #endregion
    #region Mouvements
    void PlayerMouvement()
    {
        // Set input to Move
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
            transform.position += Vector3.left * Speed;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Speed;
    }
    #endregion
    #region Game Over
    public static void GameOver()
    {
        Debug.Log("Game Over !");
    }
    #endregion
    #endregion
}
