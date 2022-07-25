using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    private void OnBecameInvisible()
    {
        if(gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject);
        }else if(gameObject.name == "Stone_5(Clone)")
        {
            Debug.Log("Stone UnActive");
            rigid.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(0, 1, 0);

            ObjectPool.objPool.InsertQueue(gameObject);
        }
    }
}
