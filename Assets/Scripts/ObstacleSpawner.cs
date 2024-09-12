using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnInterval = 2f;
    private float timeSinceLastSpawn = 0f;

    public float obstacleSpeed = 5f;  

  
    public float minY = -3f;
    public float maxY = -1f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObstacle();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnObstacle()
    {
        GameObject obstacle = ObjectPool.Instance.GetPooledObject();
        if (obstacle != null)
        {
           
            float randomY = Random.Range(minY, maxY); 
            obstacle.transform.position = new Vector2(transform.position.x, randomY);

          
            var moveScript = obstacle.GetComponent<ObstacleMovement>();
            if (moveScript == null)
            {
                moveScript = obstacle.AddComponent<ObstacleMovement>();
            }
            moveScript.speed = obstacleSpeed;  
        }
    }
}



