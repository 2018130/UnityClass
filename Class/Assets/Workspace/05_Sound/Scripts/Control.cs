using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 5.0f;
    CharacterController control;

    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 DirVector = new Vector3(horizontal, transform.position.y, vertical);
        control.Move(DirVector * speed * Time.deltaTime);
    }
}
