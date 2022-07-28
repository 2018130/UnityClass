using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Various : MonoBehaviour
{
    float timer;
    public Image stateImage;
    public Sprite[] stateIcon;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Position", 1.0f, 3.0f);

        StartCoroutine(Paint());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5.0f)
        {
            Invoke("ChangeSprite", 0f);
            timer = 0f;
        }
    }

    public void ChangeSprite()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                stateImage.sprite = stateIcon[0];
                break;
            case 1:
                stateImage.sprite = stateIcon[1];
                break;
            case 2:
                stateImage.sprite = stateIcon[2];
                break;
        }
    }

    public void Position()
    {
        transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 0, Random.Range(-2.5f, 2.5f));
    }

    IEnumerator Paint()
    {

        while (true)
        {
            yield return new WaitForSeconds(3);

            gameObject.GetComponent<Renderer>().material.color =
                new Color(Random.Range(0, 2),
                Random.Range(0, 2),
                Random.Range(0, 2));
        }
    }
}
