using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int value = 10;
        int variable = 20;

        value = variable;

        Item hat = new Item();
        Item Sword = new Item();

        hat = Sword;
        
        hat.Information(1000, 10);
        Sword.Information(5000, 10);

        Debug.Log("hat - price : " + hat.price + " size : " + hat.size);
        Debug.Log("swrd - price : " + Sword.price + " size : " + Sword.size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Item
{
    public int price;
    public int size;

    public void Information(int price, int size)
    {
        this.price = price;
        this.size = size;

    }
}