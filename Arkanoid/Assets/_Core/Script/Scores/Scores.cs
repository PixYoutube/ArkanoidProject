using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    #region Settings
    [HideInInspector] public static int Score;
    [HideInInspector] public static int HightScore;

    // Set display of Score
    [SerializeField] Text HightScoreText;
    [SerializeField] Text ScoreText;
    #endregion

    #region Meths Unity
    private void Start()
    {
        GetScore();
    }
    private void Update()
    {
        SetHightScore();
    }
    #endregion
    #region Meths
    #region Get and Set Scores
    void GetScore()
    {
        HightScore = PlayerPrefs.GetInt("HightScore", HightScore);
        HightScoreText.text = HightScore.ToString();

        Score = PlayerPrefs.GetInt("Score", Score);
        ScoreText.text = Score.ToString();
    }
    void SetHightScore()
    {
        if (Score > HightScore)
        {
            HightScore = Score;
            HightScoreText.text = "" + Score.ToString();
            PlayerPrefs.SetInt("HightScore", HightScore);
            PlayerPrefs.Save();
        }
        PlayerPrefs.SetInt("Score", Score);
        ScoreText.text = "" + Score.ToString();
    }
    #endregion
    #region Add point in Score
    public static void AddPoints(int _point, int _powerUpScore)
    {
        Score += _point * _powerUpScore;
    }
    #endregion
    #region Reset Scores
    public static void ResetPoints()
    {
        Score = 0;
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.Save();
    }
    public void ResetHightScore()
    {
        HightScore = 0;
        PlayerPrefs.SetInt("HightScore", HightScore);
        PlayerPrefs.Save();
        HightScoreText.text = "" + HightScore.ToString();
    }
    #endregion
    #endregion
}
