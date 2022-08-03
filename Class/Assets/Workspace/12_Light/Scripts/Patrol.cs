using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    int target = 3;
    [SerializeField]
    float speed = 1.0f;
    [SerializeField]
    float degree;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target, 1, 0), speed * Time.deltaTime);

        if(transform.position.x >= 3)
        {
            target = -3;
        }else if(transform.position.x <= -3)
        {
            target = 3;
        }

        degree += Time.deltaTime;
        if(degree >= 360)
        {
            degree = 0;
        }
        Debug.Log(degree);
        RenderSettings.skybox.SetFloat("_Rotation", degree);
    }
}
