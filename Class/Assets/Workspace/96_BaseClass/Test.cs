using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Oc oc = new Oc();
    }

}

public class Monster
{
    public void Attack()
    {
        Debug.Log("Attacking");
    }

    protected void Info(int health, int damage)
    {
        Debug.Log(health + " " + damage);
    }

}

public class Oc : Monster
{
    public Oc()
    {
        Attack();
        Info(100, 10);
    }
}