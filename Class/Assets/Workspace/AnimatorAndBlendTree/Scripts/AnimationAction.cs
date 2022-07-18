using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Running();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Kick();
        }
    }

    public void Kick()
    {
        animator.Play("Kick");
    }

    public void Running()
    {
        animator.Play("Run");
    }
}
