using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    protected int health;
    protected float height;

    private void Start()
    {
        Orc orc = new Orc();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Information()
    {
        Debug.Log("Health : " + health);
        Debug.Log("Height : " + height);
    }
}

public class Orc : Instance
{
    public Orc()
    {
        health = 10;
        height = 100.5f;
        Information();
    }
}