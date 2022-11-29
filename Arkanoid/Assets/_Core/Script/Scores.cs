using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public static int Score;
    public static int HightScore;
    [SerializeField] Text HightScoreText;
    [SerializeField] Text ScoreText;

    private void Start()
    {
        GetScore();
    }
    private void Update()
    {
        SetHightScore();
    }
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
    public static void AddPoints(int _point, int _powerUpScore)
    {
        Score += _point * _powerUpScore;
    }
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
}
