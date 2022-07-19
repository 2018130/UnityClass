using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendAnimation : MonoBehaviour
{
    private Animator animator;

    //한글
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 dirVector = new Vector3(horizontal, 0, vertical);

        transform.Translate(dirVector * Time.deltaTime);
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
