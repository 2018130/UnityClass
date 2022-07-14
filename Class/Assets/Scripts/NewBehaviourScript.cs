using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0f, 1f)]
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
