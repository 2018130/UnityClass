using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin;
    public float revolutionSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(origin.transform.position, Vector3.down,revolutionSpeed * Time.deltaTime);
    }
}
