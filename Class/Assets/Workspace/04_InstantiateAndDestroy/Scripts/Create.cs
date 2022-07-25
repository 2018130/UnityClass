using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject Prefeb;

    public void GenericCreate() 
    {
        Instantiate(Prefeb, new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void PoolCreate()
    {
        ObjectPool.objPool.GetQueue();
    }
}
