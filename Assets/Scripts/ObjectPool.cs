using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
   
    public static ObjectPool Instance;

   
    private List<GameObject> pooledObjects;

   
    public GameObject objectPrefab;

   
    public int poolSize = 10;

    private void Awake()
    {
      
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

   
    public GameObject GetPooledObject()
    {
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

      
        GameObject newObj = Instantiate(objectPrefab);
        newObj.SetActive(true);
        pooledObjects.Add(newObj);
        return newObj;
    }
}
