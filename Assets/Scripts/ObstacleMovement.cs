using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
       
        transform.Translate(Vector2.left * speed * Time.deltaTime);

       
        if (transform.position.x < -10f) 
        {
            ScoreManager.Instance.AddScore(10);  
            gameObject.SetActive(false); 
        }
    }
}


