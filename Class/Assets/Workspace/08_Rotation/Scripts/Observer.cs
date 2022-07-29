using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target.transform.position) <= 5)
        {
            transform.LookAt(target.transform);
        }
        else
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
    }
}
