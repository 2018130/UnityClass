using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objPool;
    public GameObject prefab;
    public Queue<GameObject> queue = new Queue<GameObject>();

    private void Start()
    {
        objPool = this;
        for(int i = 0; i < 10; i++)
        {
            GameObject tmpPrefab = Instantiate(prefab, new Vector3(0, 1, 0), Quaternion.identity);
            queue.Enqueue(tmpPrefab);
            tmpPrefab.SetActive(false);
        }
    }

    public void InsertQueue(GameObject pObj)
    {
        queue.Enqueue(pObj);
        pObj.SetActive(false);
    }
    
    public GameObject GetQueue()
    {
        GameObject tmpPrefab = queue.Dequeue();
        tmpPrefab.SetActive(true);

        return tmpPrefab;
    }
}
