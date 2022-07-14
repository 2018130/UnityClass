using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data
{
    public Sprite sprite;
    public string name;
    public int price;
}

public class LifeCycle : MonoBehaviour
{
    public Data[] data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    private void Awake()
    {
        for(int i = 0; i < data.Length; i++)
        {
            priceUI[i].text = data[i].price.ToString();
            nameUI[i].text = data[i].name;
            spriteUI[i].sprite = data[i].sprite;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is Called");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
