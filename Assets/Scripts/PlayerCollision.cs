using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
           
            ScoreManager.Instance.CheckHighScore();

           
            SceneManager.LoadScene("GameOverScene");
        }
    }
}



