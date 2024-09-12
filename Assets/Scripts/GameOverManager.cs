using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text currentScoreText;
    public Text highScoreText;

    private void Start()
    {
        
        if (ScoreManager.Instance != null)
        {
            
            currentScoreText.text = "Score: " + ScoreManager.Instance.GetCurrentScore().ToString();
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
  
    }

    public void RetryGame()
    {
       
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene("Game");
    }

    
}

