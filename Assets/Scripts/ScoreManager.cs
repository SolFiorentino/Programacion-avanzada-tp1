using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public Text scoreText;
    public Text highScoreText;

    private int currentScore = 0;
    private int highScore = 0;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);  
        }

        
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    private void Start()
    {


        
        if (scoreText == null || highScoreText == null)
        {
            GameObject scoreTextObject = GameObject.Find("CurrentScoreText");
            GameObject highScoreTextObject = GameObject.Find("HighScoreText");

            if (scoreTextObject != null)
            {
                scoreText = scoreTextObject.GetComponent<Text>();
            }
            if (highScoreTextObject != null)
            {
                highScoreText = highScoreTextObject.GetComponent<Text>();
            }
        }

        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        currentScore += points;
        UpdateScoreUI();
    }

    public void ResetScore()
    {
        currentScore = 0;
        UpdateScoreUI();
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Current Score: " + currentScore.ToString();
        }

        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }

    public void CheckHighScore()
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }
}







