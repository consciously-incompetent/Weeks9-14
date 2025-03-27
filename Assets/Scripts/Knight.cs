using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer SR;
    Animator animator;
    public float speed = 4;
    public bool canRun = true;

    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        float direction = Input.GetAxisRaw("Horizontal");

        SR.flipX = direction < 0;

        animator.SetFloat("movement", MathF.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            
            animator.SetTrigger("attack");
            canRun = false;
        }


        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
        

    }



    public void AttackHasFinished()
    {
        canRun = true;
    }
}
